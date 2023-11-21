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
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            // Forms
            InitializeComponent();
            Bitmap img = new Bitmap(Environment.CurrentDirectory + @"\img\background02.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            //   Usuario usuarioResultado = Login.loginUsuario(@"\datos\MOCK_DATA.json", this.MailtextBox.Text, this.ClavetextBox.Text); // org
            //Usuario usuarioResultado = Login.loginUsuario(@"\datos\MOCK_DATA.json", "admin@admin.com", "12345678"); // Debug
            Usuario usuarioResultado = Login.loginUsuario(@"\\DATOS\Usuarios.json", "admin@admin.com", "12345678"); // Debug

            foreach (EPerfiles perfilesPosibles in Enum.GetValues(typeof(EPerfiles))) // compara con todos los perfiles hasta encontrar el que es
            {
                //   MessageBox.Show(usuarioResultado.perfil + "|" + perfilesPosibles.ToString());
                if (usuarioResultado.perfil.Equals(perfilesPosibles.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    //MessageBox.Show(usuarioResultado.perfil); // Debug

                    Form_Inicio formInicio = new Form_Inicio(usuarioResultado); // Preparamos siguiente panel

                    switch (usuarioResultado.perfil) // Tener en cuenta el formato de Json
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
            }
           /* if (usuarioResultado.Legajo != 0)
            {
                MensajeAvisoText.Text = "Su perfil ya no es valido para esta version";
            }*/
        }

        private void MensajeAvisoText_Click(object sender, EventArgs e)
        {

        }

        private void Vendedor_Click(object sender, EventArgs e)
        {
            Usuario usuarioResultado = Login.loginUsuario(@"\\DATOS\Usuarios.json", "cgorgen@vendedor.com", "123abc45"); // Debug

            foreach (EPerfiles perfilesPosibles in Enum.GetValues(typeof(EPerfiles))) // compara con todos los perfiles hasta encontrar el que es
            {
                if (usuarioResultado.perfil.Equals(perfilesPosibles.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Form_Inicio formInicio = new Form_Inicio(usuarioResultado); // Preparamos siguiente panel

                    switch (usuarioResultado.perfil) // Tener en cuenta el formato de Json
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
            }
        }

        private void Supervisor_Click(object sender, EventArgs e)
        {
            Usuario usuarioResultado = Login.loginUsuario(@"\\DATOS\Usuarios.json", "trobinson@super.com", "12345678"); // Debug

            foreach (EPerfiles perfilesPosibles in Enum.GetValues(typeof(EPerfiles))) // compara con todos los perfiles hasta encontrar el que es
            {
                if (usuarioResultado.perfil.Equals(perfilesPosibles.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Form_Inicio formInicio = new Form_Inicio(usuarioResultado); // Preparamos siguiente panel

                    switch (usuarioResultado.perfil) // Tener en cuenta el formato de Json
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
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Usuario usuarioResultado = Login.loginUsuario(@"\\DATOS\Usuarios.json", "admin@admin.com", "12345678"); // Debug

            foreach (EPerfiles perfilesPosibles in Enum.GetValues(typeof(EPerfiles))) // compara con todos los perfiles hasta encontrar el que es
            {
                if (usuarioResultado.perfil.Equals(perfilesPosibles.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Form_Inicio formInicio = new Form_Inicio(usuarioResultado); // Preparamos siguiente panel

                    switch (usuarioResultado.perfil) // Tener en cuenta el formato de Json
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
            }
        }
    }
}
