using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{ 
    public partial class Form_ViajesInfo : Form
    {
        private BaseDatosSQL gestorBaseDatos;
        private string connectionString = "Data Source=(local);Initial Catalog=IgnacioNatanael_2C_TPFinal;Integrated Security=True;";

        private List<ViajeVendido> viajesVendidos = new List<ViajeVendido>();

        public Form_ViajesInfo()
        {
            InitializeComponent();

            gestorBaseDatos = new BaseDatosSQL(connectionString);

            // Suscribir al evento CellContentClick
            dtgvViajesVendidos.CellContentClick += dtgvViajesVendidos_CellContentClick;
        }

        private void Form_ViajesInfo_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            dtgvViajesVendidos.Rows.Clear();
            viajesVendidos = gestorBaseDatos.ObtenerViajesVendidos();

            if (viajesVendidos == null)
            {
                return;
            }

            foreach (var viaje in viajesVendidos)
            {
                dtgvViajesVendidos.Rows.Add(
                    viaje.IDViaje,
                    viaje.DNIPasajero,
                    viaje.NombreCompleto,
                    viaje.TipoVuelo,
                    viaje.EquipajeMano,
                    viaje.EquipajeDeposito,
                    viaje.PrecioTotal,
                    viaje.FechadeVenta
                );
            }
           // dtgvViajesVendidos.Rows.RemoveAt(dtgvViajesVendidos.Rows.Count);
        }

        private void dtgvViajesVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clicada pertenece a la columna "PrecioTotal"
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvViajesVendidos.Columns["PrecioTotal"].Index)
            {
                // Obtener el objeto ViajeVendido correspondiente a la fila clicada
                ViajeVendido viajeSeleccionado = viajesVendidos[e.RowIndex];

                // Obtener el detalle del precio desde el objeto ViajeVendido
                string detallePrecio = viajeSeleccionado.MostrarDetallePrecios();

                // Mostrar el detalle en un MessageBox
                MessageBox.Show(detallePrecio, "Detalle de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
