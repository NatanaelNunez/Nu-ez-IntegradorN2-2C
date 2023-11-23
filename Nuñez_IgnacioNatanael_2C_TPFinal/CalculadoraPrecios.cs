using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Clase que representa una calculadora de precios.
    /// </summary>
    public class CalculadoraPrecios
    {
        /// <summary>
        /// Calcula el precio total teniendo en cuenta el precio base, el precio por kilómetro,
        /// el precio del equipaje de depósito y si el viaje es de ida y vuelta.
        /// </summary>
        /// <param name="precioBase">Precio base del viaje.</param>
        /// <param name="precioXKM">Precio por kilómetro.</param>
        /// <param name="precioEquipajeDepo">Precio del equipaje de depósito.</param>
        /// <param name="idaVueltaSi">Indica si el viaje es de ida y vuelta.</param>
        /// <returns>El precio total del viaje.</returns>
        public decimal CalcularPrecioTotal(decimal precioBase, decimal precioXKM,
                                           decimal precioEquipajeDepo, bool idaVueltaSi)
        {
            decimal valorTotal = -1;

            decimal KMConIdaVuelta = precioXKM;
            if (idaVueltaSi)
            {
                KMConIdaVuelta = KMConIdaVuelta * 2;
            }

            valorTotal = precioBase + KMConIdaVuelta + precioEquipajeDepo;

            return valorTotal;
        }
    }
}
