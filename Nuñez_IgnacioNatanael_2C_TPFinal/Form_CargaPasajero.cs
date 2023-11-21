using Entidades;
using SerializarDeserializar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public partial class Form_CargaPasajero : Form
    {
        public Form_CargaPasajero()
        {
            InitializeComponent();
        }

        private void Form_CargaPasajero_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false; // Deshabilitar el botón al inicio
            ValidarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Realizar la lógica para continuar aquí
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            // Validar campos y mostrar avisos
            bool camposValidos = true;

            camposValidos &= Validaciones.ValidarNombre(textBoxNombre.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;
                return;
            }

            camposValidos &= Validaciones.ValidarApellido(textBoxApellido.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;

                return;
            }
            camposValidos &= Validaciones.ValidarDNI(textBoxDni.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;

                return;
            }
            camposValidos &= Validaciones.ValidarEdad(textBoxEdad.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;
                return;
            }

            camposValidos &= Validaciones.ValidarTelefono(textBoxTelefono.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;
                return;
            }

            camposValidos &= Validaciones.ValidarCorreo(textBoxCorreo.Text, labelAviso);
            if (!camposValidos)
            {
                // Habilitar o deshabilitar el botón según la validación de campos
                btnAceptar.Enabled = camposValidos;
                return;
            }

            btnAceptar.Enabled = camposValidos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {  // Validar campos antes de continuar
            if (!Validaciones.ValidarCampos(textBoxNombre.Text, textBoxApellido.Text, textBoxDni.Text, textBoxEdad.Text, textBoxTelefono.Text, textBoxCorreo.Text, labelAviso))
            {
                // Campos no válidos, mostrar mensaje de error y salir
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Campos válidos, crear un nuevo pasajero
            Pasajero nuevoPasajero = new Pasajero
            {
                nombre = textBoxNombre.Text,
                apellido = textBoxApellido.Text,
                dni = int.Parse(textBoxDni.Text),
                edad = int.Parse(textBoxEdad.Text),
                equipMano = 0, // Puedes asignar valores por defecto o modificar según tus necesidades
                equipBodega = 0,
                telefono = textBoxTelefono.Text,
                estado = true, // Puedes asignar valores por defecto o modificar según tus necesidades
                correo = textBoxCorreo.Text,
                fechaIngreso = DateTime.Now, // Puedes asignar la fecha actual
                perfil = "" // Puedes asignar valores por defecto o modificar según tus necesidades
            };

            // Agregar el nuevo pasajero al archivo XML
            ManagerFileXMLPasajeros.AgregarUnPasajero(@"\datos\PASAJEROS_DATA.xml", nuevoPasajero);

            // Mostrar mensaje de éxito
            MessageBox.Show("Pasajero agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cerrar el formulario
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
