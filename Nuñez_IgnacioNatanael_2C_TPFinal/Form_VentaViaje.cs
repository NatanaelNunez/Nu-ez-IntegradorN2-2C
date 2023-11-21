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
using SerializarDeserializar;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public partial class Form_VentaViaje : Form
    {
        List<Pasajero> pasajerosList = new List<Pasajero>();
        private bool flagCargaPrimeraVes = false;

        private int numEquipajeDeMano = 0;
        private int numEquipajeDeDeposito = 0;

        // Declarar diccionario para almacenar kilómetros por nombre de destino
        private Dictionary<string, int> cmbDestinosKilometraje = new Dictionary<string, int>();

        // Precios adicionales y total
        private float precioAdiBase = 5000;
        private float precioAdiKM = 0;
        private float precioAdiEquipajeDepo = 0;
        private bool idaVueltaSi = false;

        private float precioTotal = 0;

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
            float KMConIdaVuelta = precioAdiKM;
            if (idaVueltaSi)
            {
                KMConIdaVuelta = KMConIdaVuelta * 2;
            }

            precioTotal = precioAdiBase + KMConIdaVuelta + precioAdiEquipajeDepo;


            lbEnumPrecioTotal.Text = "$ " + precioTotal.ToString();
        }

        //
        private void InicializarComboBoxDestinos()
        {
            // Configurar opciones de vuelos nacionales
            for (int i = 0; i < Enum.GetValues(typeof(DestinosNacionales)).Length; i++)
            {
                var destino = (DestinosNacionales)Enum.GetValues(typeof(DestinosNacionales)).GetValue(i);
                var atributo = GetKilometrajeAttribute(destino);
                int km = atributo?.Kilometros ?? 0;
                string nombreDestino = destino.ToString();
                string destinoConKm = $"{nombreDestino}";
                cmbDestinos.Items.Add(nombreDestino);
                cmbDestinosKilometraje[nombreDestino] = km; // Guardar kilómetros en el diccionario
            }

            // Configurar opciones de vuelos Internacionales
            for (int i = 0; i < Enum.GetValues(typeof(DestinosInternacionales)).Length; i++)
            {
                var destino = (DestinosInternacionales)Enum.GetValues(typeof(DestinosInternacionales)).GetValue(i);
                var atributo = GetKilometrajeAttribute(destino);
                int km = atributo?.Kilometros ?? 0;
                string nombreDestino = destino.ToString();
                string destinoConKm = $"{nombreDestino}";
                cmbDestinos.Items.Add(nombreDestino);
                cmbDestinosKilometraje[nombreDestino] = km; // Guardar kilómetros en el diccionario
            }

            // Seleccionar la primera opción por defecto
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


        //



        private void radioBtnNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNacional.Checked)
            {
                radioBtnInternacional.Checked = false;
            }

            // Actualizar las opciones del ComboBox según el tipo de vuelo seleccionado
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
            }

            // Actualizar las opciones del ComboBox según el tipo de vuelo seleccionado
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void lbNumCantidadMano_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            string nombrePasajero = textBoxNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombrePasajero))
            {
                // Mostrar un mensaje de advertencia en forma de diálogo
                MessageBox.Show("Debe seleccionar un pasajero primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // El TextBoxNombre tiene un valor, realizar la lógica correspondiente
                // ...
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

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
            corroborarPasajero();
        }

        private void corroborarPasajero()
        {
            // Obtener el DNI del textBoxDni
            string dniBuscado = textBoxDni.Text.Trim();

            // Realizar la búsqueda del pasajero según el DNI (puedes implementar tu lógica aquí)
            Pasajero pasajeroEncontrado = BuscarPasajeroPorDni(dniBuscado);

            if (pasajeroEncontrado != null)
            {
                // Si se encontró el pasajero, actualizar el textBoxNombre con su nombre y apellido
                textBoxNombre.Text = $"{pasajeroEncontrado.Nombre} {pasajeroEncontrado.Apellido}";
            }
            else
            {
                // Si no se encontró el pasajero, mostrar un mensaje de advertencia
                MessageBox.Show("Pasajero no encontrado. Se abrira el formulario de carga", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Clear(); // Limpiar el textBoxNombre



                // Deshabilitar temporalmente los controles del formulario actual
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                Form_CargaPasajero formCargaPasajero = new Form_CargaPasajero();
                formCargaPasajero.FormClosed += (sender, e) =>
                {
                    // Reactivar los controles del formulario actual al cerrar el formulario de eliminación
                    foreach (Control c in this.Controls)
                    {
                        c.Enabled = true;
                    }
                };

                // Mostrar el formulario
                formCargaPasajero.StartPosition = FormStartPosition.CenterScreen;
                formCargaPasajero.Show(this);
            }
        }

        // Método de ejemplo para buscar un pasajero por DNI (debes implementar tu lógica real)
        private Pasajero BuscarPasajeroPorDni(string dni)
        {
            // nos aseguraremos que se actualice la info del grid utilizando el xml solo cuano inicia el form
            if (flagCargaPrimeraVes == false)
            {
                flagCargaPrimeraVes = true;
                pasajerosList = ManagerFileXMLPasajeros.Deserializar(@"\datos\PASAJEROS_DATA.xml");
            }

            // Buscar el pasajero por DNI en la lista
            Pasajero pasajeroEncontrado = pasajerosList.FirstOrDefault(p => p.dni.ToString() == dni);

            return pasajeroEncontrado;
        }
    }
}
