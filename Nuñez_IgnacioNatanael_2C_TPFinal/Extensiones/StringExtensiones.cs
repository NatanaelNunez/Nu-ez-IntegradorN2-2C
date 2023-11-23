using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Extensiones
{
    /// <summary>
    /// Clase de extensión para operaciones con cadenas de texto.
    /// </summary>
    public static class StringExtensiones
    {
        /// <summary>
        /// Verifica si la cadena contiene solo letras.
        /// </summary>
        /// <param name="str">Cadena de texto a verificar.</param>
        /// <returns>True si la cadena contiene solo letras, false de lo contrario.</returns>
        public static bool ContieneSoloLetras(this string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
