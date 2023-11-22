using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un pasajero. Heredado de Usuario
    /// </summary>
    public class Pasajero : Usuario
    {
        #region Atributos

        private DateTime fechaIngreso;
        private int dni;
        private int edad;
        private int equipMano;
        private int equipBodega;
        private string telefono;
        private bool estado;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Pasajero.
        /// </summary>
        /// <param name="fechaIngre">Fecha de ingreso del pasajero.</param>
        /// <param name="ape">Apellido del pasajero.</param>
        /// <param name="nom">Nombre del pasajero.</param>
        /// <param name="cor">Correo del pasajero.</param>
        /// <param name="cla">Clave del pasajero.</param>
        /// <param name="per">Perfil del pasajero.</param>
        /// <param name="dniC">DNI del pasajero.</param>
        /// <param name="est">Estado del pasajero.</param>
        /// <param name="edadC">Edad del pasajero.</param>
        /// <param name="equipManoC">Cantidad de equipaje de mano del pasajero.</param>
        /// <param name="equipoBodegaC">Cantidad de equipaje de bodega del pasajero.</param>
        /// <param name="telefonoC">Número de teléfono del pasajero.</param>
        public Pasajero(DateTime fechaIngre, string ape, string nom, string cor,
            string cla, string per, int dniC, bool est, int edadC, int equipManoC,
            int equipoBodegaC, string telefonoC) : base(ape, nom, cor, cla, per)
        {
            this.fechaIngreso = fechaIngre;
            this.dni = dniC;
            this.edad = edadC;
            this.equipMano = equipManoC;
            this.equipBodega = equipoBodegaC;
            this.telefono = telefonoC;
            this.estado = est;
        }

        /// <summary>
        /// Constructor sin parámetros de la clase Pasajero.
        /// </summary>
        public Pasajero() { }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece la fecha de ingreso del pasajero.
        /// </summary>
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        /// <summary>
        /// Obtiene o establece el DNI del pasajero.
        /// </summary>
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Obtiene o establece la edad del pasajero.
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de equipaje de mano del pasajero.
        /// </summary>
        public int EquipajeMano
        {
            get { return equipMano; }
            set { equipMano = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de equipaje de bodega del pasajero.
        /// </summary>
        public int EquipajeBodega
        {
            get { return equipBodega; }
            set { equipBodega = value; }
        }

        /// <summary>
        /// Obtiene o establece el número de teléfono del pasajero.
        /// </summary>
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /// <summary>
        /// Obtiene o establece el estado del pasajero.
        /// </summary>
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion
    }
}
