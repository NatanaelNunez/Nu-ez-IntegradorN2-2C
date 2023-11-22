using Nu�ez_IgnacioNatanael_2C_TPFinal.Extensiones;
using System;
using System.Text.RegularExpressions;

namespace Nu�ez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Clase est�tica que proporciona m�todos para validar diferentes tipos de datos.
    /// </summary>
    public static class Validaciones
    {
        /// <summary>
        /// Valida si el nombre proporcionado es v�lido.
        /// </summary>
        /// <param name="nombre">Nombre a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el nombre es v�lido, de lo contrario, false.</returns>
        public static bool ValidarNombre(string nombre, Label labelAviso)
        {
            if (string.IsNullOrEmpty(nombre) || !nombre.ContieneSoloLetras())
            {
                MostrarAviso("Ingrese un nombre v�lido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el apellido proporcionado es v�lido.
        /// </summary>
        /// <param name="apellido">Apellido a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el apellido es v�lido, de lo contrario, false.</returns>
        public static bool ValidarApellido(string apellido, Label labelAviso)
        {
            if (string.IsNullOrEmpty(apellido) || !apellido.ContieneSoloLetras())
            {
                MostrarAviso("Ingrese un apellido v�lido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el DNI proporcionado es v�lido.
        /// </summary>
        /// <param name="dni">DNI a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el DNI es v�lido, de lo contrario, false.</returns>
        public static bool ValidarDNI(string dni, Label labelAviso)
        {
            if (!int.TryParse(dni, out _))
            {
                MostrarAviso("Ingrese un DNI v�lido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si la edad proporcionada es v�lida.
        /// </summary>
        /// <param name="edad">Edad a validar como cadena.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si la edad es v�lida, de lo contrario, false.</returns>
        public static bool ValidarEdad(string edad, Label labelAviso)
        {
            if (!int.TryParse(edad, out int edadNum))
            {
                // No se pudo convertir a un valor num�rico
                MostrarAviso("Ingrese una edad numerica v�lida", labelAviso);
                return false;
            }

            if (edadNum <= 17 || edadNum >= 100)
            {
                MostrarAviso("Ingrese una edad v�lida (18 - 99)", labelAviso);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida si el tel�fono proporcionado es v�lido.
        /// </summary>
        /// <param name="telefono">Tel�fono a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el tel�fono es v�lido, de lo contrario, false.</returns>
        public static bool ValidarTelefono(string telefono, Label labelAviso)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                MostrarAviso("Ingrese un tel�fono v�lido", labelAviso);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida si el correo proporcionado es v�lido.
        /// </summary>
        /// <param name="correo">Correo a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si el correo es v�lido, de lo contrario, false.</returns>
        public static bool ValidarCorreo(string correo, Label labelAviso)
        {
            if (!Regex.IsMatch(correo, @"^(.+)@(.+)$"))
            {
                MostrarAviso("Ingrese un correo v�lido", labelAviso);
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
        /// <param name="telefono">Tel�fono a validar.</param>
        /// <param name="correo">Correo a validar.</param>
        /// <param name="labelAviso">Etiqueta para mostrar mensajes de aviso.</param>
        /// <returns>Devuelve true si todos los campos son v�lidos, de lo contrario, false.</returns>
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
