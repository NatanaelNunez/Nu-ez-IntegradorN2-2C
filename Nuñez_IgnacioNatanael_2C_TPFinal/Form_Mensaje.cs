using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Formulario para mostrar mensajes durante procesos largos.
    /// </summary>
    public partial class Form_Mensaje : Form
    {
        /// <summary>
        /// Constructor de la clase Form_Mensaje.
        /// </summary>
        public Form_Mensaje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra un mensaje en el formulario.
        /// </summary>
        /// <param name="mensaje">El mensaje a mostrar.</param>
        public void MostrarMensaje(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarMensaje(mensaje)));
            }
            else
            {
                labelMensaj.Text = mensaje;
                Show();
            }
        }

        /// <summary>
        /// Oculta el formulario de mensaje.
        /// </summary>
        public void OcultarMensaje()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OcultarMensaje()));
            }
            else
            {
                Hide();
            }
        }



        private void labelMensaje_Click(object sender, EventArgs e)
        {
        }
        private void Form_Mensaje_Load(object sender, EventArgs e)
        {
        }
        private void labelMensaj_Click(object sender, EventArgs e)
        {
        }
    }
}
