using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos
        public string apellido;
        public string nombre;
        public string correo;
        private string clave;
        public string perfil;


        // public int entero;
        //  private double doble;
        // protected bool booleano;

        #endregion

        #region Propiedad
        /*  public double Doble
          {
              get
              {
                  return this.doble;
              }
              set
              {
                  this.doble = value;
              }
          }*/

        #endregion

        #region Constructor
        public Usuario(string ape, string nom, string cor, string cla, string per)
        {
            apellido = ape;
            nombre = nom;
            correo = cor;
            clave = cla;
            perfil = per;
        }

        public Usuario() {}
        #endregion


        #region Propiedad
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        /*public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }*/

        #endregion

        #region Método
        public string Mostrar()
        {
            return $"Apellido: {apellido}Nombre: {nombre} Legajo: " +
                $"2 Correo: {correo} Clave:  {clave} " +
                $" Perfil:  {perfil}";

        }

        /*
            return $"legajo: {this.legajo} | nombre: {this.nombre} | apellido: {this.apellido}" +
                $"| correo: {this.correo} | clave: {this.clave} | perfil: {this.perfil}" +
                $"| activo: {this.activo}";
        */
        #endregion
    }
}