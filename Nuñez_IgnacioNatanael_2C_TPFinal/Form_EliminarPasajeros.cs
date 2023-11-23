using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Nuñez_IgnacioNatanael_2C_TPFinal.Eventos;
using SerializarDeserializar;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{

    /// <summary>
    /// Formulario para eliminar pasajeros.
    /// </summary>
    public partial class Form_EliminarPasajeros : Form
    {
        private List<Pasajero> pasajerosList = new List<Pasajero>();
        private bool flagCargaPrimeraVez = false;

        /// <summary>
        /// Constructor de la clase Form_EliminarPasajeros.
        /// </summary>
        public Form_EliminarPasajeros()
        {
            InitializeComponent();
            CargarDatos();
            this.dtgvPasajeros.SelectionChanged += new System.EventHandler(this.dtgvPasajeros_SelectionChanged);

        }

        /// <summary>
        /// Carga los datos de los pasajeros en el formulario.
        /// </summary>
        private void CargarDatos()
        {
            if (!flagCargaPrimeraVez)
            {
                string raiz = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = Path.Combine(raiz, "datos\\PASAJEROS_DATA.xml");

                flagCargaPrimeraVez = true;
                pasajerosList = ManagerFileXMLPasajeros.Deserializar(ruta);
            }

            if (pasajerosList != null)
            {
                dtgvPasajeros.Rows.Clear();

                foreach (var pasajero in pasajerosList)
                {
                    string fechaFormateada = pasajero.FechaIngreso.ToString("dd/MM/yyyy");
                    dtgvPasajeros.Rows.Add(pasajero.Dni, pasajero.Nombre, pasajero.Apellido, fechaFormateada, pasajero.Estado);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos de pasajeros desde el archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de eliminación de un pasajero.
        /// </summary>
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDNI.Text.Trim(), out int dniAEliminar))
            {
                Pasajero pasajeroAEliminar = pasajerosList.Find(p => p.Dni == dniAEliminar);

                if (pasajeroAEliminar != null)
                {
                    pasajerosList.Remove(pasajeroAEliminar);
                    CargarDatos();

                    buttonCancelar.Visible = true;
                    buttonCancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró un pasajero con el DNI especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega un pasajero de prueba.
        /// </summary>
        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            pasajerosList.Add(new Pasajero(DateTime.Now, "Juan", "Gas", "gmail", "000", "pasajero", 48331553, true, 25, 5, 55, "Telefono"));
            CargarDatos();

            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            string ruta = Path.Combine(raiz, "datos\\PASAJEROS_DATA.xml");

            ManagerFileXMLPasajeros.Serializar(ruta, pasajerosList);
        }

        /// <summary>
        /// Maneja el evento de cambio de selección en el DataGridView.
        /// </summary>
        private void dtgvPasajeros_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvPasajeros.SelectedCells.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvPasajeros.Rows[dtgvPasajeros.SelectedCells[0].RowIndex];

                string dni = filaSeleccionada.Cells["UsuarioDNI"].Value?.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value?.ToString();
                string fechaIngreso = filaSeleccionada.Cells["FechaIngreso"].Value?.ToString();

                textBoxDNI.Text = dni;
                textBoxNombre.Text = nombre;
                textBoxApellido.Text = apellido;

                if (!string.IsNullOrEmpty(fechaIngreso) && DateTime.TryParse(fechaIngreso, out DateTime fecha))
                {
                    textBoxFechaIngreso.Text = fecha.ToString("dd/MM/yyyy");
                }
                else
                {
                    textBoxFechaIngreso.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón Cancelar.
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón Aceptar.
        /// </summary>
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            //* Animacion de guardar  *//

            // Suscribe un método al evento MensajeMostrado
            GestorMensaje.MensajeMostrado += MostrarMensajeHandler;
            GestorMensaje.InicializarFormMensaje();

            // Llama al gestor de mensajes
            GestorMensaje.MostrarMensajeConProceso(() =>
            {
                // Simula el proceso de guardar datos 
                Thread.Sleep(6000);
            }, "Guardando datos...");

            //* Fin animacion de guardar *//

            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            string ruta = Path.Combine(raiz, "datos\\PASAJEROS_DATA.xml");

            ManagerFileXMLPasajeros.Serializar(ruta, pasajerosList);


            this.Close();
        }

        private void dtgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Metodo del evento MensajeMostrado
        private static void MostrarMensajeHandler(object sender, MensajeEventArgs e)
        {
            Console.WriteLine($"Mensaje mostrado: {e.Mensaje}");
            // Se puede agregar más codigo
        }

        private void Form_EliminarPasajeros_Load(object sender, EventArgs e)
        {

        }
    }
}
