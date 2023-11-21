using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using SerializarDeserializar;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public partial class Form_EliminarPasajeros : Form
    {
        List<Pasajero> pasajerosList = new List<Pasajero>();

        private bool flagCargaPrimeraVes = false;

        public Form_EliminarPasajeros()
        {
            InitializeComponent();
            CargarDatos();
            this.dtgvPasajeros.SelectionChanged += new System.EventHandler(this.dtgvPasajeros_SelectionChanged);
        }

        private void CargarDatos()
        {
            // nos aseguraremos que se actualice la info del grid utilizando el xml solo cuano inicia el form
            if (flagCargaPrimeraVes == false)
            {
                flagCargaPrimeraVes = true;
                pasajerosList = ManagerFileXMLPasajeros.Deserializar(@"\datos\PASAJEROS_DATA.xml");
            }

            if (pasajerosList != null)
            {
                dtgvPasajeros.Rows.Clear();

                foreach (var pasajero in pasajerosList)
                {
                    string fechaFormateada = pasajero.fechaIngreso.ToString("dd/MM/yyyy");
                    dtgvPasajeros.Rows.Add(pasajero.dni, pasajero.Nombre, pasajero.Apellido, fechaFormateada, pasajero.estado);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos de pasajeros desde el archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FiltroBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AplicarFiltro();
            }
        }

        private void AplicarFiltro()
        {
            // Aceptar los cambios pendientes antes de realizar el filtrado
            dtgvPasajeros.EndEdit();

            // Filtrar las filas del DataGridView según el texto ingresado en la primera columna (USUARIO (DNI))
            foreach (DataGridViewRow fila in dtgvPasajeros.Rows)
            {
                // Obtener el valor de la primera celda (columna "UsuarioDNI")
                string valorCeldaUsuario = fila.Cells["UsuarioDNI"].Value?.ToString();

                // Mostrar u ocultar la fila según si el DNI contiene el texto de búsqueda
                fila.Visible = !string.IsNullOrEmpty(valorCeldaUsuario)
                    && valorCeldaUsuario.IndexOf(FiltroBoxInput.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            // Obtener el DNI desde el TextBoxDNI y convertirlo a int
            if (int.TryParse(textBoxDNI.Text.Trim(), out int dniAEliminar))
            {
                // Buscar el pasajero - avanzado
                Pasajero pasajeroAEliminar = pasajerosList.FirstOrDefault(p => p.dni == dniAEliminar);

                if (pasajeroAEliminar != null)
                {
                    pasajerosList.Remove(pasajeroAEliminar);

                    buttonCancelar.Visible = true;
                    buttonCancelar.Enabled = true;
                    // Actualizar el DataGridView
                    CargarDatos(); // Puedes llamar a tu método existente para cargar los datos
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

            // Actualizar el DataGridView 
            //CargarDatos();
            //ManagerFileXMLPasajeros.Serializar(@"\datos\PASAJEROS_DATA.xml", pasajerosList);
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            pasajerosList.Add(new Pasajero(DateTime.Now, "Juan", "Gas", "gmail", "000", "pasajero", 48331553, true, 25, 5, 55, "Telefono"));

            // Actualizar el DataGridView y serializar los datos
            CargarDatos();
            ManagerFileXMLPasajeros.Serializar(@"\datos\PASAJEROS_DATA.xml", pasajerosList);
        }

        

        private void Form_EliminarPasajeros_Load(object sender, EventArgs e)
        {

        }

        private void dtgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            ManagerFileXMLPasajeros.Serializar(@"\datos\PASAJEROS_DATA.xml", pasajerosList);
            // Cerrar el formulario actual
            this.Close();
        }

        private void dtgvPasajeros_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvPasajeros.SelectedCells.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvPasajeros.Rows[dtgvPasajeros.SelectedCells[0].RowIndex];

                string dni = filaSeleccionada.Cells["UsuarioDNI"].Value?.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                string Apellido = filaSeleccionada.Cells["Apellido"].Value?.ToString();
                string fechaIngreso = filaSeleccionada.Cells["FechaIngreso"].Value?.ToString();

                textBoxDNI.Text = dni;
                textBoxNombre.Text = nombre;
                textBoxApellido.Text = Apellido;

                if (!string.IsNullOrEmpty(fechaIngreso) && DateTime.TryParse(fechaIngreso, out DateTime fecha))
                {
                    textBoxFechaIngreso.Text = fecha.ToString("dd/MM/yyyy");
                }
                else
                {
                    textBoxFechaIngreso.Text = string.Empty;
                }

                //Eliminar.Enabled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
