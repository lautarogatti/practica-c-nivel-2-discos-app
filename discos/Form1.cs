using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using helpers;

namespace discos
{
    public partial class Form1 : Form
    {
        private List<Disco> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Fecha lanz.");
            cboCampo.Items.Add("Cant. canciones");
            cboCampo.SelectedIndex = -1;
        }

        private void cargarGrilla()
        {
            DiscoService service = new DiscoService();
            listaDiscos = service.listarDiscos();
            dgvDiscos.DataSource = listaDiscos;
            ocultarColumnas();
            cargarImagen(listaDiscos[0].UrlImagen);
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbxDisco.Load(url);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Disco discoSeleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(discoSeleccionado.UrlImagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            if(dgvDiscos.CurrentRow != null)
            {
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                frmAltaDisco modificar = new frmAltaDisco(seleccionado);
                modificar.ShowDialog();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor seleccione el disco a modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            DiscoService service = new DiscoService();
            try
            {
                if (dgvDiscos.CurrentRow != null)
                {
                    DialogResult validacion = MessageBox.Show("Esta a punto de eliminar un disco, esta accion no se puede revertir, continuar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (validacion == DialogResult.Yes)
                    {
                        seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                        service.eliminar(seleccionado.Id);
                        cargarGrilla();

                    }
                }
                else
                    MessageBox.Show("Por favor seleccione un disco para eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnElimLogico_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            DiscoService service = new DiscoService();
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult validacion = MessageBox.Show("Esta a punto de eliminar logicamente un disco, continuar?", "Eliminar Logico", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (validacion == DialogResult.Yes)
                {
                    //service.eliminarLogico(seleccionado.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DiscoService service = new DiscoService();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string clave = txbClave.Text;
                dgvDiscos.DataSource = service.filtrar(campo, criterio, clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (Validar.validarCboSinSeleccion(cboCampo, "campo"))
                return true;

            if (Validar.validarCboSinSeleccion(cboCriterio, "criterio"))
                return true;

            if (cboCampo.SelectedItem.ToString() == "Fecha lanz.")
            {
                if (!Validar.isValidDate(txbClave.Text))
                {
                    MessageBox.Show("No se ha ingresado una fecha valida, por favor ingresela de nuevo de con el siguiente formato (año/mes/dia)");
                    return true;
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Cant. canciones")
            {
                if (!Validar.soloNumeros(txbClave))
                {
                    MessageBox.Show("Por favor ingrese solo números en el campo de clave");
                    return true;
                }
            }

            return false;
        }

        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
        }

        private void txbFiltroR_TextChanged(object sender, EventArgs e)
        {
            filtrarRapido();
        }

        private void filtrarRapido()
        {
            List<Disco> listaFiltrada;
            string filtro = txbFiltroR.Text;
            listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = cboCampo.SelectedItem.ToString();
            if(seleccionado == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Contiene");
            }
            else if(seleccionado == "Fecha lanz.")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Anterior al");
                cboCriterio.Items.Add("Posterior al");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
            }
        }
    }
}
