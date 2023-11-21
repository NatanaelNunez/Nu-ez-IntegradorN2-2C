using Entidades;
using System.Diagnostics;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public partial class Form_Inicio : Form
    {
        //DECLARO ATRIBUTO
        private Usuario usuarioActivo; // constante estatica universal
        public Form_Inicio(Usuario usuarioAct)
        {
            // Forms
            InitializeComponent();
            Bitmap img = new Bitmap(Environment.CurrentDirectory + @"\img\background01.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //

            usuarioActivo = usuarioAct;
           // MessageBox.Show(usuarioActivo.nombre + " g1");

            NombreUsuarioActivo.Text = usuarioActivo.nombre;
        }

        public void Form_Inicio_Load(object sender, System.EventArgs e)
        {
            switch (usuarioActivo.perfil) // Tener en cuenta el formato de Json
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

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) // ABM PASAJEROS
        {
            if (usuarioActivo.perfil != "vendedor")
            {
                MessageBox.Show("Exclusivo para Vendedores");
                return;
            }

            // Deshabilitar temporalmente los controles del formulario actual
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }

            Form_VentaViaje formVenderVuelo = new Form_VentaViaje();
            formVenderVuelo.FormClosed += (sender, e) =>
            {
                // Reactivar los controles del formulario actual al cerrar el formulario de eliminación
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            };

            // Mostrar el formulario
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

            // Iniciar una nueva instancia de la aplicación actual
            Process.Start(rutaEjecutable);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador" && usuarioActivo.perfil != "supervisor")
            {
                MessageBox.Show("Exclusivo para Administradores y Supervisores");
                return;
            }

            // Deshabilitar temporalmente los controles del formulario actual
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }

            Form_EliminarPasajeros formEliminarPasajeros = new Form_EliminarPasajeros();
            formEliminarPasajeros.FormClosed += (sender, e) =>
            {
                // Reactivar los controles del formulario actual al cerrar el formulario de eliminación
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            };

            // Mostrar el formulario
            formEliminarPasajeros.StartPosition = FormStartPosition.CenterScreen;
            formEliminarPasajeros.Show(this);
        }

        private void buttonMDViajes_Click(object sender, EventArgs e)
        {
           /* if (usuarioActivo.perfil != "administrador")
            { 
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }

            Form_ABMViajes formViajes = new Form_ABMViajes(); // Preparamos siguiente panel
            formViajes.StartPosition = FormStartPosition.CenterParent;
            formViajes.Show(this);

            // desabilitadmos temporalmente
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }*/
        }

        private void buttonMDAeronaves_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
        }

        private void Form_Inicio_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}