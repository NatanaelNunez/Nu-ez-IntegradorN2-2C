using Nuñez_IgnacioNatanael_2C_TPFinal.Extensiones;
using System;
using System.Text.RegularExpressions;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Clase estática que proporciona métodos para validar diferentes tipos de datos.
    /// </summary>
    public static class Validaciones
    {
        /// <summary>
        /// Valida si el nombre proporcionado es válido.
        /// </summary>
        /// <param name="nombre">Nombre a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el nombre es válido, de lo contrario, false.</returns>
        public static bool ValidarNombre(string nombre, Label labelAviso)
        {
            if (string.IsNullOrEmpty(nombre) || !nombre.ContieneSoloLetras())
            {
                MostrarAviso("Ingrese un nombre válido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el apellido proporcionado es válido.
        /// </summary>
        /// <param name="apellido">Apellido a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el apellido es válido, de lo contrario, false.</returns>
        public static bool ValidarApellido(string apellido, Label labelAviso)
        {
            if (string.IsNullOrEmpty(apellido) || !apellido.ContieneSoloLetras())
            {
                MostrarAviso("Ingrese un apellido válido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el DNI proporcionado es válido.
        /// </summary>
        /// <param name="dni">DNI a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el DNI es válido, de lo contrario, false.</returns>
        public static bool ValidarDNI(string dni, Label labelAviso)
        {
            if (!int.TryParse(dni, out _))
            {
                MostrarAviso("Ingrese un DNI válido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si la edad proporcionada es válida.
        /// </summary>
        /// <param name="edad">Edad a validar como cadena.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si la edad es válida, de lo contrario, false.</returns>
        public static bool ValidarEdad(string edad, Label labelAviso)
        {
            if (!int.TryParse(edad, out int edadNum))
            {
                // No se pudo convertir a un valor numérico
                MostrarAviso("Ingrese una edad numerica válida", labelAviso);
                return false;
            }

            if (edadNum <= 17 || edadNum >= 100)
            {
                MostrarAviso("Ingrese una edad válida (18 - 99)", labelAviso);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida si el teléfono proporcionado es válido.
        /// </summary>
        /// <param name="telefono">Teléfono a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el teléfono es válido, de lo contrario, false.</returns>
        public static bool ValidarTelefono(string telefono, Label labelAviso)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                MostrarAviso("Ingrese un teléfono válido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el correo proporcionado es válido.
        /// </summary>
        /// <param name="correo">Correo a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el correo es válido, de lo contrario, false.</returns>
        public static bool ValidarCorreo(string correo, Label labelAviso)
        {
            if (!Regex.IsMatch(correo, @"^(.+)@(.+)$"))
            {
                MostrarAviso("Ingrese un correo válido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Muestra un aviso utilizando la etiqueta proporcionada o muestra un cuadro de mensaje si la etiqueta es nula.
        /// </summary>
        /// <param name="mensaje">Mensaje del aviso.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
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

        /// <summary>
        /// Valida todos los campos proporcionados.
        /// </summary>
        /// <param name="nombre">Nombre a validar.</param>
        /// <param name="apellido">Apellido a validar.</param>
        /// <param name="dni">DNI a validar.</param>
        /// <param name="edad">Edad a validar.</param>
        /// <param name="telefono">Teléfono a validar.</param>
        /// <param name="correo">Correo a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si todos los campos son válidos, de lo contrario, false.</returns>
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
