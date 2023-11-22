using Entidades;
using Nuñez_IgnacioNatanael_2C_TPFinal.Eventos;
using Nuñez_IgnacioNatanael_2C_TPFinal.Exceptions;
using SerializarDeserializar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Formulario para cargar un nuevo pasajero.
    /// </summary>
    public partial class Form_CargaPasajero : Form
    {
        public Form_CargaPasajero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se ejecuta cuando se carga el formulario.
        /// </summary>
        private void Form_CargaPasajero_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false; // Deshabilitar el botón al inicio
            ValidarCampos();
        }

        /// <summary>
        /// Maneja el evento clic del botón Cancelar, cerrando el formulario.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo Nombre y realiza la validación de campos.
        /// </summary>
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo Apellido y realiza la validación de campos.
        /// </summary>
        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo DNI y realiza la validación de campos.
        /// </summary>
        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo Edad y realiza la validación de campos.
        /// </summary>
        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo Correo y realiza la validación de campos.
        /// </summary>
        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Queda atento al cambio de texto del campo Teléfono y realiza la validación de campos.
        /// </summary>
        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        /// <summary>
        /// Realiza la validación de campos y habilita o deshabilita el botón Aceptar.
        /// </summary>
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

        /// <summary>
        /// Maneja el evento clic del botón Aceptar, validando campos antes de continuar y agregando un nuevo pasajero.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //* Animacion de guardar  *//

            // Inicializa el formulario de mensaje
            GestorMensaje.InicializarFormMensaje();

            // Llama al gestor de mensajes para mostrar el mensaje y ejecutar el proceso
            GestorMensaje.MostrarMensajeConProceso(() =>
            {
                // Simula el proceso de guardar datos (reemplaza esto con tu lógica real)
                Thread.Sleep(8000);
            }, "Guardando datos...");

            //* Fin animacion de guardar *//

            try
            {
                // Validar campos antes de continuar
                if (!Validaciones.ValidarCampos(textBoxNombre.Text, textBoxApellido.Text, textBoxDni.Text, textBoxEdad.Text, textBoxTelefono.Text, textBoxCorreo.Text, labelAviso))
                {
                    throw new SaltoSeguridadInputs("Se detectó un salto de seguridad en campos requeridos.");
                }
            }
            catch (SaltoSeguridadInputs ex)
            {
                // Manejar la excepción personalizada SaltoSeguridadInputs
                MessageBox.Show($"Fallo de seguridad, se pasaron las validaciones de inputs necesarias para continuar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Campos válidos, crear un nuevo pasajero
            Pasajero nuevoPasajero = new Pasajero
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                Dni = int.Parse(textBoxDni.Text),
                Edad = int.Parse(textBoxEdad.Text),
                EquipajeMano = 0, // valor por defecto
                EquipajeBodega = 0,
                Telefono = textBoxTelefono.Text,
                Estado = true, // valor por defecto
                Correo = textBoxCorreo.Text,
                FechaIngreso = DateTime.Now, // valor por defecto
                Perfil = "Pasajero" // valor por defecto
            };

            // Agregar el nuevo pasajero al archivo XML
            ManagerFileXMLPasajeros.AgregarUnPasajero(@"\datos\PASAJEROS_DATA.xml", nuevoPasajero);

            // Mostrar mensaje de éxito
          //  MessageBox.Show("Pasajero agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario
            this.Close();
        }

        /// <summary>
        /// Maneja el evento clic del botón Cancelar, cerrando el formulario.
        /// </summary>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
