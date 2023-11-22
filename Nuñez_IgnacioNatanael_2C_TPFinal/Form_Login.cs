using Entidades;
using SerializarDeserializar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{

    /// <summary>
    /// Formulario para el inicio de sesión.
    /// </summary>
    public partial class Form_Login : Form
    {
        /// <summary>
        /// Constructor de la clase <see cref="Form_Login"/>.
        /// </summary>
        public Form_Login()
        {
            // Forms
            InitializeComponent();
            Bitmap img = new Bitmap(Environment.CurrentDirectory + @"\img\background02.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Evento de carga del formulario.
        /// </summary>
        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón de aceptar.
        /// </summary>
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            // Obtener directorio raíz
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            // Construir ruta
            string ruta = Path.Combine(raiz, "datos\\usuarios.json");

            Usuario usuarioResultado = Login.LoginUsuario(ruta, this.MailtextBox.Text, this.ClavetextBox.Text);
            pedirLogin(usuarioResultado);
        }


        /// <summary>
        /// Le pediremos al archivo Login.cs que nos loguee con el usuario pasado 
        /// </summary>
        private void pedirLogin(Usuario usuarioIndicado)
        {
            if (usuarioIndicado != null)
            {
                Form_Inicio formInicio = new Form_Inicio(usuarioIndicado);

                MensajeAvisoText.Text = $"Bienvenido, {usuarioIndicado.Perfil}";

                switch (usuarioIndicado.Perfil.ToLower()) // Convertir a minúsculas para hacer la comparación más flexible
                {
                    case "administrador":
                        MensajeAvisoText.Text = "Administrador";
                        formInicio.Show();
                        this.Hide();
                        break;
                    case "supervisor":
                        MensajeAvisoText.Text = "Supervisor";
                        formInicio.Show();
                        this.Hide();
                        break;
                    case "vendedor":
                        MensajeAvisoText.Text = "Vendedor";
                        formInicio.Show();
                        this.Hide();
                        break;
                    case "pasajero":
                        MensajeAvisoText.Text = "Verificar Usuario es pasajero";
                        break;
                    case "cliente":
                        MensajeAvisoText.Text = "Verificar Usuario es cliente";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Verifique correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el texto de aviso.
        /// </summary>
        private void MensajeAvisoText_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón de vendedor. DEBUG
        /// </summary>
        private void Vendedor_Click(object sender, EventArgs e)
        {
            // Obtener directorio raíz
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            // Construir ruta
            string ruta = Path.Combine(raiz, "datos\\usuarios.json");

            Usuario usuarioResultado = Login.LoginUsuario(ruta, "cgorgen@vendedor.com", "123abc45");

            pedirLogin(usuarioResultado);
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón de supervisor. DEBUG
        /// </summary>
        private void Supervisor_Click(object sender, EventArgs e)
        {
            // Obtener directorio raíz
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            // Construir ruta
            string ruta = Path.Combine(raiz, "datos\\usuarios.json");

            Usuario usuarioResultado = Login.LoginUsuario(ruta, "trobinson@super.com", "12345678");

            pedirLogin(usuarioResultado);
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón de administrador. DEBUG
        /// </summary>
        private void Admin_Click(object sender, EventArgs e)
        {
            // Obtener directorio raíz
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            // Construir ruta
            string ruta = Path.Combine(raiz, "datos\\usuarios.json");

            Usuario usuarioResultado = Login.LoginUsuario(ruta, "admin@admin.com", "12345678");

            pedirLogin(usuarioResultado);
        }
    }
}
