using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using helpers;

namespace discos
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;

        private OpenFileDialog archivo = null;

        public frmAltaDisco()
        {
            InitializeComponent();
        }

        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscoService service = new DiscoService();
            try
            {
                if (validarAlta())
                {
                    return;
                }
                if (disco == null)
                {
                    disco = new Disco();
                }
                disco.Titulo = txbNombre.Text;
                disco.FechaDeLanzamiento = DateTime.Parse(txbFechaLanz.Text);
                disco.CantCanciones = int.Parse(txbCantCan.Text);
                disco.UrlImagen = txbUrlImg.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.TipoEdicion = (TipoEdicion)cboEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    service.modificar(disco);
                    MessageBox.Show("Modificado con Exito");
                }
                else
                {
                    service.agregar(disco);
                    MessageBox.Show("Agregado con Exito");
                }

                if(archivo != null && !(txbUrlImg.Text.ToLower().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagesFolder"] + archivo.SafeFileName);
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloService estilos = new EstiloService();
            TipoEdicionService edicion = new TipoEdicionService();
            try
            {
                cboEstilo.DataSource = estilos.listarEstilos();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboEstilo.SelectedIndex = -1;
                cboEdicion.DataSource = edicion.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
                cboEdicion.SelectedIndex = -1;

                if(disco != null)
                {
                    cargarImagen(disco.UrlImagen);
                    txbNombre.Text = disco.Titulo;
                    txbFechaLanz.Text = disco.FechaDeLanzamiento.ToString();
                    txbCantCan.Text = disco.CantCanciones.ToString();
                    txbUrlImg.Text = disco.UrlImagen;
                    cboEdicion.SelectedValue = disco.TipoEdicion.Id;
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txbUrlImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImg.Text);
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbxImgAlta.Load(url);
            }
            catch (Exception)
            {
                pbxImgAlta.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

        private void btnAjuntarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbUrlImg.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private bool validarAlta()
        {
            List<TextBox> requeridos = new List<TextBox>
            {
                txbNombre,
                txbFechaLanz,
                txbCantCan
            };

            foreach (TextBox requerido in requeridos)
            {
                if (Validar.isEmpty(requerido.Text))
                {
                    MessageBox.Show("Un espacio requerido esta vacío, asegurese de completar todos los espacios que contienen (*)");
                    return true;
                }
                if (requerido == txbFechaLanz && !Validar.isValidDate(requerido.Text))
                {
                    MessageBox.Show("No se ha ingresado una fecha valida, por favor ingresela de nuevo con el siguiente formato (año/mes/dia)");
                    return true;
                }
                if (requerido == txbCantCan && !Validar.soloNumeros(requerido))
                {
                    MessageBox.Show("Por favor ingrese solo números en el campo de Cant.Canciones");
                    return true;
                }

            }

            if (Validar.validarCboSinSeleccion(cboEstilo, "Estilo"))
            {
                return true;
            }

            if (Validar.validarCboSinSeleccion(cboEdicion, "Edicion"))
            {
                return true;
            }

            return false;
        }
    }
}
