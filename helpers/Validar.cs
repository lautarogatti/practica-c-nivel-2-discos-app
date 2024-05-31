using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpers
{
    public static class Validar
    {
        public static bool validarCboSinSeleccion(ComboBox cbo, string nombreCbo)
        {
            if (cbo.SelectedIndex < 0)
            {
                MessageBox.Show("El " + nombreCbo + " se encuentra sin completar, por favor elegir una de las opciones de la lista");
                return true;
            }
            else
                return false;
        }

        public static bool isValidDate(string date)
        {
            DateTime DateValue;
            bool isValidDate = DateTime.TryParse(date, out DateValue);
            return isValidDate;
        }

        public static bool soloNumeros(TextBox clave)
        {
            foreach (char caracter in clave.Text)
            {
                if (!char.IsNumber(caracter))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isEmpty(string clave)
        {
            if (clave == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
