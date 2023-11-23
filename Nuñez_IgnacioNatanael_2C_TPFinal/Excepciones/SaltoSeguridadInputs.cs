using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Exceptions
{
    /// <summary>
    /// Excepción personalizada para detectar saltos de seguridad en los inputs.
    /// </summary>
    internal class SaltoSeguridadInputs : Exception
    {
        /// <summary>
        /// Constructor de la excepción con un mensaje opcional.
        /// </summary>
        /// <param name="message">Mensaje de la excepción.</param>
        public SaltoSeguridadInputs(string? message) : base(message)
        {
        }
    }
}
