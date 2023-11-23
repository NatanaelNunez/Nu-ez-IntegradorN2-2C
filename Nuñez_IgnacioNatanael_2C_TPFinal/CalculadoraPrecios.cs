using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public class CalculadoraPrecios
    {
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
