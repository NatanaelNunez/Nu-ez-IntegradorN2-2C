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

        // 1 siempre = Ok
        public static Usuario loginUsuario(string path, string correo, string clave)
        {

          //  MessageBox.Show(path);

            usuariosArray = ManagerFileJSON<Usuario>.Deserializar(path);
            Usuario usuarioNull = new Usuario("No","existe","gamil","000","usuario"); // algo mal

            /* foreach (Usuario item in usuariosArray)
             {
                 MessageBox.Show(item.Mostrar());
             }*/

            foreach (Usuario item in usuariosArray)
            {
                if (item.correo == correo && item.Clave == clave) // Equal
                {
                    return item; // entro
                }
            }

            MessageBox.Show("Verifique Correo y Contraseña");
          //  MessageBox.Show("Comunicarce con Soporte");
            return usuarioNull;
        }

    }
}
