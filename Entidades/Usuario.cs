using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un usuario.
    /// </summary>
    public class Usuario
    {
        #region Atributos
        private string apellido;
        private string nombre;
        private string correo;
        private string clave;
        private string perfil;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase Usuario.
        /// </summary>
        /// <param name="ape">Apellido del usuario.</param>
        /// <param name="nom">Nombre del usuario.</param>
        /// <param name="cor">Correo del usuario.</param>
        /// <param name="cla">Clave del usuario.</param>
        /// <param name="per">Perfil del usuario.</param>
        public Usuario(string ape, string nom, string cor, string cla, string per)
        {
            this.apellido = ape;
            this.nombre = nom;
            this.correo = cor;
            this.clave = cla;
            this.perfil = per;
        }

        /// <summary>
        /// Constructor sin parámetros de la clase Usuario.
        /// </summary>
        public Usuario() { }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el apellido del usuario.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el correo del usuario.
        /// </summary>
        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        /// <summary>
        /// Obtiene o establece la clave del usuario.
        /// </summary>
        public string Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }

        /// <summary>
        /// Obtiene o establece el perfil del usuario.
        /// </summary>
        public string Perfil
        {
            get { return this.perfil; }
            set { this.perfil = value; }
        }

        #endregion

        #region Método

        /// <summary>
        /// Muestra la información del usuario.
        /// </summary>
        /// <returns>Información formateada del usuario.</returns>
        public string Mostrar()
        {
            return $"Apellido: {this.Apellido} Nombre: {this.Nombre} Correo: {this.Correo} Clave: {this.Clave} Perfil: {this.Perfil}";
        }

        #endregion
    }
}
