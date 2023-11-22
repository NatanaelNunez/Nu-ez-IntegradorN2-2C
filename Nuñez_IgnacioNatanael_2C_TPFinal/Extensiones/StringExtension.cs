using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Extensiones
{
    public static class StringExtensions
    {
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
