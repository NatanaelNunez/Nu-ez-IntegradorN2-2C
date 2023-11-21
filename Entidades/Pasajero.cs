using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
      public class Pasajero : Usuario
      {
        #region Atributos
        public DateTime fechaIngreso;
        public int dni;
        public int edad;
        public int equipMano;
        public int equipBodega;
        public string telefono;
        public bool estado;

        #region Constructores
        public Pasajero(DateTime fechaIngre, string ape, string nom, string cor, 
            string cla, string per, int dniC,bool est ,int edadC, int equipManoC, 
            int equipoBodegaC,string telefonoC) : base(ape, nom, cor, cla, per)
        {
            this.dni = dniC;
            this.fechaIngreso = fechaIngre;
            this.edad = edadC;
            this.equipMano = equipManoC;
            this.equipBodega = equipoBodegaC;
            this.telefono = telefonoC;
            this.estado = est;
        }
        public Pasajero() {}
        #endregion

        #endregion

        #region Método
        #endregion

    }
}