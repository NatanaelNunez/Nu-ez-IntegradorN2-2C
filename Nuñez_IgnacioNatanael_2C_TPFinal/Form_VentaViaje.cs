using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Nuñez_IgnacioNatanael_2C_TPFinal.Eventos;
using Nuñez_IgnacioNatanael_2C_TPFinal.Exceptions;
using SerializarDeserializar;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Clase que representa el formulario de venta de viajes.
    /// </summary>
    public partial class Form_VentaViaje : Form
    {
        private List<Pasajero> pasajerosList = new List<Pasajero>();
        private bool flagCargaPrimeraVez = false;

        private int numEquipajeDeMano = 0;
        private int numEquipajeDeDeposito = 0;

        private Dictionary<string, int> cmbDestinosKilometraje = new Dictionary<string, int>();

        private decimal precioAdiBase = 5000;
        private decimal precioAdiKM = 0;
        private decimal precioAdiEquipajeDepo = 0;
        private bool idaVueltaSi = false;
        private bool vueloNacionalSi = true;

        private decimal precioTotal = 0;

        /// <summary>
        /// Constructor de la clase Form_VentaViaje.
        /// </summary>
        public Form_VentaViaje()
        {
            InitializeComponent();
            InicializarComboBoxDestinos();
        }

        private void Form_VentaViaje_Load(object sender, EventArgs e)
        {
            ActualizarPrecioTotal();
        }

        private void ActualizarPrecioTotal()
        {
            decimal KMConIdaVuelta = precioAdiKM;
            if (idaVueltaSi)
            {
                KMConIdaVuelta = KMConIdaVuelta * 2;
            }

            precioTotal = precioAdiBase + KMConIdaVuelta + precioAdiEquipajeDepo;

            lbEnumPrecioTotal.Text = "$ " + precioTotal.ToString();
        }

        private void InicializarComboBoxDestinos()
        {
            // Configurar opciones de vuelos nacionales
            for (int i = 0; i < Enum.GetValues(typeof(DestinosNacionales)).Length; i++)
            {
                var destino = (DestinosNacionales)Enum.GetValues(typeof(DestinosNacionales)).GetValue(i);
                var atributo = GetKilometrajeAttribute(destino);
                int km = atributo?.Kilometros ?? 0;
                string nombreDestino = destino.ToString();
                cmbDestinos.Items.Add(nombreDestino);
                cmbDestinosKilometraje[nombreDestino] = km;
            }

            // Configurar opciones de vuelos internacionales
            for (int i = 0; i < Enum.GetValues(typeof(DestinosInternacionales)).Length; i++)
            {
                var destino = (DestinosInternacionales)Enum.GetValues(typeof(DestinosInternacionales)).GetValue(i);
                var atributo = GetKilometrajeAttribute(destino);
                int km = atributo?.Kilometros ?? 0;
                string nombreDestino = destino.ToString();
                cmbDestinos.Items.Add(nombreDestino);
                cmbDestinosKilometraje[nombreDestino] = km;
            }

            cmbDestinos.SelectedIndex = 0;
            radioBtnNacional.Checked = true;
            radioBtnInternacional.Checked = false;
        }

        private KilometrajeAttribute GetKilometrajeAttribute(Enum valorEnum)
        {
            var campo = valorEnum.GetType().GetField(valorEnum.ToString());

            if (campo != null)
            {
                var atributo = campo.GetCustomAttribute<KilometrajeAttribute>();
                return atributo;
            }

            return null;
        }

        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDestinoSeleccionado = cmbDestinos.SelectedItem.ToString();
            int kmSeleccionado = cmbDestinosKilometraje[nombreDestinoSeleccionado];
            lbKilometraje.Text = $"{kmSeleccionado} km";

            precioAdiKM = kmSeleccionado * 85;
            ActualizarPrecioTotal();
        }

        private void radioBtnNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNacional.Checked)
            {
                radioBtnInternacional.Checked = false;
                vueloNacionalSi = true;
            }

            if (radioBtnNacional.Checked)
            {
                cmbDestinos.Items.Clear();
                foreach (DestinosNacionales destino in Enum.GetValues(typeof(DestinosNacionales)))
                {
                    cmbDestinos.Items.Add(destino);
                }
                cmbDestinos.SelectedIndex = 0;
            }
        }

        private void radioBtnInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnInternacional.Checked)
            {
                radioBtnNacional.Checked = false;
                vueloNacionalSi = false;
            }

            if (radioBtnInternacional.Checked)
            {
                cmbDestinos.Items.Clear();
                foreach (DestinosInternacionales destino in Enum.GetValues(typeof(DestinosInternacionales)))
                {
                    cmbDestinos.Items.Add(destino);
                }
                cmbDestinos.SelectedIndex = 0;
            }
        }

        private void btnRestaEquiMano_Click(object sender, EventArgs e)
        {
            if (numEquipajeDeMano > 0)
            {
                numEquipajeDeMano--;
                ActualizarLabelNumMano();
            }
        }

        private void btnSumEquiMano_Click(object sender, EventArgs e)
        {
            if (numEquipajeDeMano < 3)
            {
                numEquipajeDeMano++;
                ActualizarLabelNumMano();
            }
        }

        private void ActualizarLabelNumMano()
        {
            lbNumCantidadMano.Text = numEquipajeDeMano.ToString();
        }

        private void btnRestaEquiDepo_Click(object sender, EventArgs e)
        {
            if (numEquipajeDeDeposito > 0)
            {
                numEquipajeDeDeposito--;
                ActualizarLabelNumDepo();

                precioAdiEquipajeDepo = numEquipajeDeDeposito * 1500;
                ActualizarPrecioTotal();
            }
        }

        private void btnSumEquiDepo_Click(object sender, EventArgs e)
        {
            if (numEquipajeDeDeposito < 10)
            {
                numEquipajeDeDeposito++;
                ActualizarLabelNumDepo();

                precioAdiEquipajeDepo = numEquipajeDeDeposito * 1500;
                ActualizarPrecioTotal();
            }
        }

        private void ActualizarLabelNumDepo()
        {
            lbNumCantidadDepo.Text = numEquipajeDeDeposito.ToString();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            string nombrePasajero = textBoxNombre.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(nombrePasajero))
                {
                    throw new SaltoSeguridadInputs("Se detectó un salto de seguridad en campos requeridos.");
                }
                else
                {
                    mandarVentaSQL();
                    Close();
                }
            }
            catch (SaltoSeguridadInputs ex)
            {
                MessageBox.Show($"Fallo de seguridad, hay ingresos de datos vacíos no permitidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mandarVentaSQL()
        {
            //* Animacion de guardar  *//

            // Suscribe un método al evento MensajeMostrado
            GestorMensaje.MensajeMostrado += MostrarMensajeHandler;
            GestorMensaje.InicializarFormMensaje();

            // Llama al gestor de mensajes
            GestorMensaje.MostrarMensajeConProceso(() =>
            {
                // Simula el proceso de guardar datos 
                Thread.Sleep(5000);
            }, "Guardando datos...");

            //* Fin animacion de guardar *//


            string connectionString = "Data Source=(local);Initial Catalog=IgnacioNatanael_2C_TPFinal;Integrated Security=True;";
            BaseDatosSQL baseDatos = new BaseDatosSQL(connectionString);

            if (int.TryParse(textBoxDni.Text.Trim(), out int dni))
            {
            }
            else
            {
                // Manejar excepción
            }

            string nombreCompleto = textBoxNombre.Text.Trim();

            decimal precioConIdaYVuelta = 0;
            if (idaVueltaSi)
            {
                precioConIdaYVuelta = precioAdiKM * 2;
                precioAdiKM = 0;
            }

            baseDatos.AgregarVenta(dni, nombreCompleto, vueloNacionalSi, idaVueltaSi,
               precioAdiBase, precioAdiKM, precioConIdaYVuelta, precioAdiEquipajeDepo, precioTotal,
               numEquipajeDeMano, numEquipajeDeDeposito);

            MessageBox.Show("Se finalizó la compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void rdbIdaVueltaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIdaVueltaSi.Checked)
            {
                rdbIdaVueltaNo.Checked = false;
                idaVueltaSi = true;
                ActualizarPrecioTotal();
            }
        }

        private void rdbIdaVueltaNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIdaVueltaNo.Checked)
            {
                rdbIdaVueltaSi.Checked = false;
                idaVueltaSi = false;
                ActualizarPrecioTotal();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            corroborarPasajero(false);
        }


        private void corroborarPasajero(bool quiereCrear)
        {
            if (!quiereCrear)
            {
                string dniBuscado = textBoxDni.Text.Trim();
                Pasajero pasajeroEncontrado = BuscarPasajeroPorDni(dniBuscado);

                if (pasajeroEncontrado != null)
                {
                    textBoxNombre.Text = $"{pasajeroEncontrado.Nombre} {pasajeroEncontrado.Apellido}";
                    return;
                }
                else
                {
                    MessageBox.Show("Pasajero no encontrado. Se abrirá el formulario de carga", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Clear();
                }
            }

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }

            Form_CargaPasajero formCargaPasajero = new Form_CargaPasajero();
            formCargaPasajero.FormClosed += (sender, e) =>
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            };

            formCargaPasajero.StartPosition = FormStartPosition.CenterScreen;
            formCargaPasajero.Show(this);
        }

        private Pasajero BuscarPasajeroPorDni(string dni)
        {
            if (flagCargaPrimeraVez == false)
            {
                flagCargaPrimeraVez = true;
                pasajerosList = ManagerFileXMLPasajeros.Deserializar(@"\datos\PASAJEROS_DATA.xml");
            }

            Pasajero pasajeroEncontrado = pasajerosList.FirstOrDefault(p => p.Dni.ToString() == dni);
            return pasajeroEncontrado;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            corroborarPasajero(true);
        }


        // Metodo del evento MensajeMostrado
        private static void MostrarMensajeHandler(object sender, MensajeEventArgs e)
        {
            Console.WriteLine($"Mensaje mostrado: {e.Mensaje}");
            // Se puede agregar más codigo
        }
    }
}
