using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public static class Validaciones
    {
        public static bool ValidarNombre(string nombre, Label labelAviso)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                MostrarAviso("Ingrese un nombre válido", labelAviso);
                return false;
            }
            return true;
        }

        public static bool ValidarApellido(string apellido, Label labelAviso)
        {
            if (string.IsNullOrEmpty(apellido))
            {
                MostrarAviso("Ingrese un apellido válido", labelAviso);
                return false;
            }
            return true;
        }

        public static bool ValidarDNI(string dni, Label labelAviso)
        {
            if (!int.TryParse(dni, out _))
            {
                MostrarAviso("Ingrese un DNI válido", labelAviso);
                return false;
            }
            return true;
        }

        public static bool ValidarEdad(string edad, Label labelAviso)
        {
            if (!int.TryParse(edad, out _))
            {
                MostrarAviso("Ingrese una edad válida", labelAviso);
                return false;
            }
            return true;
        }

        public static bool ValidarTelefono(string telefono, Label labelAviso)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                MostrarAviso("Ingrese un teléfono válido", labelAviso);
                return false;
            }
            return true;
        }

        public static bool ValidarCorreo(string correo, Label labelAviso)
        {
            if (!Regex.IsMatch(correo, @"^(.+)@(.+)$"))
            {
                MostrarAviso("Ingrese un correo válido", labelAviso);
                return false;
            }
            return true;
        }

        private static void MostrarAviso(string mensaje, Label labelAviso)
        {
            if (labelAviso != null)
            {
                labelAviso.Text = mensaje;
            }
            else
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static bool ValidarCampos(string nombre, string apellido, string dni, string edad, string telefono, string correo, Label labelAviso)
        {
            return ValidarNombre(nombre, labelAviso) &&
                   ValidarApellido(apellido, labelAviso) &&
                   ValidarDNI(dni, labelAviso) &&
                   ValidarEdad(edad, labelAviso) &&
                   ValidarTelefono(telefono, labelAviso) &&
                   ValidarCorreo(correo, labelAviso);
        }
    }
}
