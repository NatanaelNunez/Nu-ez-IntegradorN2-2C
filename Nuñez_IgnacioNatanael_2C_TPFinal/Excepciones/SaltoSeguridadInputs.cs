using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Exceptions
{
    internal class SaltoSeguridadInputs : Exception
    {
        public SaltoSeguridadInputs(string? message) : base(message)
        {
        }
    }
}
