using Entidades;
using SerializarDeserializar;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    internal class Login
    {
        // Variables
        private static List<Usuario> usuariosArray = new List<Usuario>();

        /// <summary>
        /// Intenta realizar el inicio de sesión para un usuario dado su correo y clave.
        /// </summary>
        /// <param name="path">Ruta del archivo donde se almacenan los usuarios.</param>
        /// <param name="correo">Correo del usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        /// <returns>El usuario si el inicio de sesión es exitoso, o null si no se encuentra.</returns>
        public static Usuario LoginUsuario(string path, string correo, string clave)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            try
            {
                usuariosArray = ManagerFileJSON<Usuario>.Deserializar(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar: " + ex.Message);
            }


            foreach (Usuario item in usuariosArray)
            {
                if (item.Correo.Equals(correo) && item.Clave.Equals(clave))
                {
                    return item; // Usuario encontrado
                }
            }

            MessageBox.Show("Verifique Correo y Contraseña");
            return null; // Usuario no encontrado
        }

    }
}
