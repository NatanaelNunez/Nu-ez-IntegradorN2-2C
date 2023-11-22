using Entidades;
using System.Diagnostics;
using System.Windows.Forms;

namespace Nu�ez_IgnacioNatanael_2C_TPFinal
{
    public partial class Form_Inicio : Form
    {
        // ATRIBUTO DECLARADO
        private Usuario usuarioActivo;

        /// <summary>
        /// Constructor del formulario de inicio.
        /// </summary>
        /// <param name="usuarioAct">Usuario activo que inici� sesi�n.</param>
        public Form_Inicio(Usuario usuarioAct)
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Environment.CurrentDirectory + @"\img\background01.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            usuarioActivo = usuarioAct;
            NombreUsuarioActivo.Text = usuarioActivo.Nombre;
        }

        /// <summary>
        /// Evento de carga del formulario.
        /// </summary>
        /// <param name="sender">Objeto que env�a el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Form_Inicio_Load(object sender, System.EventArgs e)
        {
            switch (usuarioActivo.Perfil)
            {
                case "administrador":
                    break;
                case "supervisor":
                    break;
                case "vendedor":
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L�gica del bot�n 1
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Perfil != "vendedor")
            {
                MessageBox.Show("Exclusivo para Vendedores");
                return;
            }

            // Deshabilitar temporalmente los controles del formulario actual
            DesabilitarControles();

            Form_VentaViaje formVenderVuelo = new Form_VentaViaje();
            formVenderVuelo.FormClosed += (sender, e) =>
            {
                // Reactivar los controles del formulario actual al cerrar el formulario de venta
                HabilitarControles();
            };

            formVenderVuelo.StartPosition = FormStartPosition.CenterScreen;
            formVenderVuelo.Show(this);
        }

        private void NombreUsuarioActivo_Click(object sender, EventArgs e)
        {
            IniciarNuevaInstancia();
        }

        private void IniciarNuevaInstancia()
        {
            // Obtener la ruta del ejecutable actual
            string rutaEjecutable = Application.ExecutablePath;

            // Iniciar una nueva instancia de la aplicaci�n actual
            Process.Start(rutaEjecutable);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Perfil != "administrador" && usuarioActivo.Perfil != "supervisor")
            {
                MessageBox.Show("Exclusivo para Administradores y Supervisores");
                return;
            }

            // Deshabilitar temporalmente los controles del formulario actual
            DesabilitarControles();

            Form_EliminarPasajeros formEliminarPasajeros = new Form_EliminarPasajeros();
            formEliminarPasajeros.FormClosed += (sender, e) =>
            {
                // Reactivar los controles del formulario actual al cerrar el formulario de eliminaci�n
                HabilitarControles();
            };

            formEliminarPasajeros.StartPosition = FormStartPosition.CenterScreen;
            formEliminarPasajeros.Show(this);
        }

        private void buttonMDViajes_Click(object sender, EventArgs e)
        {
            // L�gica del bot�n de gesti�n de viajes
        }

        private void buttonMDAeronaves_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
            // L�gica del bot�n de gesti�n de aeronaves para administradores
        }

        private void BtnVentasInfo_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Perfil != "administrador" && usuarioActivo.Perfil != "supervisor")
            {
                MessageBox.Show("Exclusivo para Administradores y Supervisores");
                return;
            }

            // Deshabilitar temporalmente los controles del formulario actual
            DesabilitarControles();

            Form_ViajesInfo formVentasInfo = new Form_ViajesInfo();
            formVentasInfo.FormClosed += (sender, e) =>
            {
                // Reactivar los controles del formulario actual al cerrar el formulario de informaci�n de ventas
                HabilitarControles();
            };

            formVentasInfo.StartPosition = FormStartPosition.CenterScreen;
            formVentasInfo.Show(this);
        }


        /// <summary>
        /// Deshabilita temporalmente los controles del formulario actual.
        /// </summary>
        private void DesabilitarControles()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        /// <summary>
        /// Reactiva los controles del formulario actual.
        /// </summary>
        private void HabilitarControles()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }
    }
}
