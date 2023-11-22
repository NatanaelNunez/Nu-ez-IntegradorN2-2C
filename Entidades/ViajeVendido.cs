using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un viaje vendido.
    /// </summary>
    public class ViajeVendido
    {
        #region Atributos

        private int idViaje;
        private int dniPasajero;
        private string nombreCompleto;
        private string tipoVuelo;
        private int equipajeMano;
        private int equipajeDeposito;
        private decimal precioBase;
        private decimal precioAdicionalxKM;
        private decimal precioAdicionalIdaVuelta;
        private decimal precioEquipajeDeposito;
        private decimal precioTotal;
        private DateTime fechadeVenta;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase ViajeVendido.
        /// </summary>
        /// <param name="idViaj">ID del viaje.</param>
        /// <param name="dniPASA">DNI del pasajero.</param>
        /// <param name="nombreC">Nombre completo del pasajero.</param>
        /// <param name="tipoV">Tipo de vuelo.</param>
        /// <param name="equipajeM">Cantidad de equipaje de mano.</param>
        /// <param name="equipajeDepo">Cantidad de equipaje de depósito.</param>
        /// <param name="precioB">Precio base del viaje.</param>
        /// <param name="precioAdxKM">Precio adicional por kilómetro.</param>
        /// <param name="precioADidVt">Precio adicional por ida y vuelta.</param>
        /// <param name="precioEquipDepo">Precio del equipaje de depósito.</param>
        /// <param name="precioT">Precio total del viaje.</param>
        /// <param name="fechaVent">Fecha de venta del viaje.</param>
        public ViajeVendido(int idViaj, int dniPASA, string nombreC, string tipoV, int equipajeM, int equipajeDepo,
            decimal precioB, decimal precioAdxKM, decimal precioADidVt, decimal precioEquipDepo, decimal precioT,
            DateTime fechaVent)
        {
            this.idViaje = idViaj;
            this.dniPasajero = dniPASA;
            this.nombreCompleto = nombreC;
            this.tipoVuelo = tipoV;
            this.equipajeMano = equipajeM;
            this.equipajeDeposito = equipajeDepo;
            this.precioBase = precioB;
            this.precioAdicionalxKM = precioAdxKM;
            this.precioAdicionalIdaVuelta = precioADidVt;
            this.precioEquipajeDeposito = precioEquipDepo;
            this.precioTotal = precioT;
            this.fechadeVenta = fechaVent;
        }

        /// <summary>
        /// Constructor sin parámetros de la clase ViajeVendido.
        /// </summary>
        public ViajeVendido() { }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el ID del viaje.
        /// </summary>
        public int IDViaje
        {
            get { return this.idViaje; }
            set { this.idViaje = value; }
        }

        /// <summary>
        /// Obtiene o establece el DNI del pasajero.
        /// </summary>
        public int DNIPasajero
        {
            get { return this.dniPasajero; }
            set { this.dniPasajero = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre completo del pasajero.
        /// </summary>
        public string NombreCompleto
        {
            get { return this.nombreCompleto; }
            set { this.nombreCompleto = value; }
        }

        /// <summary>
        /// Obtiene o establece el tipo de vuelo.
        /// </summary>
        public string TipoVuelo
        {
            get { return this.tipoVuelo; }
            set { this.tipoVuelo = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de equipaje de mano.
        /// </summary>
        public int EquipajeMano
        {
            get { return this.equipajeMano; }
            set { this.equipajeMano = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de equipaje de depósito.
        /// </summary>
        public int EquipajeDeposito
        {
            get { return this.equipajeDeposito; }
            set { this.equipajeDeposito = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio base del viaje.
        /// </summary>
        public decimal PrecioBase
        {
            get { return this.precioBase; }
            set { this.precioBase = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio adicional por kilómetro.
        /// </summary>
        public decimal PrecioAdicionalxKM
        {
            get { return this.precioAdicionalxKM; }
            set { this.precioAdicionalxKM = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio adicional por ida y vuelta.
        /// </summary>
        public decimal PrecioAdicionalIdaVuelta
        {
            get { return this.precioAdicionalIdaVuelta; }
            set { this.precioAdicionalIdaVuelta = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio del equipaje de depósito.
        /// </summary>
        public decimal PrecioEquipajeDeposito
        {
            get { return this.precioEquipajeDeposito; }
            set { this.precioEquipajeDeposito = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio total del viaje.
        /// </summary>
        public decimal PrecioTotal
        {
            get { return this.precioTotal; }
            set { this.precioTotal = value; }
        }

        /// <summary>
        /// Obtiene o establece la fecha de venta del viaje.
        /// </summary>
        public DateTime FechadeVenta
        {
            get { return this.fechadeVenta; }
            set { this.fechadeVenta = value; }
        }

        #endregion

        #region Método

        /// <summary>
        /// Muestra los detalles de precios del viaje.
        /// </summary>
        /// <returns>Detalles de precios formateados.</returns>
        public string MostrarDetallePrecios()
        {
            return $"Precio Base: ${this.PrecioBase}\t \nPrecioAdicionalxKM: ${this.PrecioAdicionalxKM}\t" +
                $"\nPrecioAdicionalIdaVuelta: ${this.PrecioAdicionalIdaVuelta}\t \nPrecioEquipajeDeposito: ${this.PrecioEquipajeDeposito}\t " +
                $" \nPrecioTotal: ${this.PrecioTotal}\t";
        }

        #endregion
    }
}
