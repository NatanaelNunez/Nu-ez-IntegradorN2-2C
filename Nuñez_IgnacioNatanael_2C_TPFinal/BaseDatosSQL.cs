using System;
using System.Data.SqlClient;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    public class BaseDatosSQL
    {
        private string connectionString;

        public BaseDatosSQL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AgregarVenta(int dni, string NombreCompleto, bool nacional, bool idaVuelta,
            decimal precioBase, decimal precioAdicionalPorKilometro, decimal precioAdicionalIdaVuelta,
            decimal precioEquipajeDeposito, decimal precioTotal, int equipajeMano, int equipajeDeposito)
        {
            DateTime fechaVenta = DateTime.Now;

            string insertQuery = @"INSERT INTO ViajesVendidos 
                                   (DNI, NombreCompleto, Nacional, IdaVuelta, PrecioBase, PrecioAdicionalPorKilometro, 
                                    PrecioAdicionalIdaVuelta, PrecioEquipajeDeposito, PrecioTotal, EquipajeMano, EquipajeDeposito, FechaVenta) 
                                   VALUES 
                                   (@DNI, @NombreCompleto, @Nacional, @IdaVuelta, @PrecioBase, @PrecioAdicionalPorKilometro, 
                                    @PrecioAdicionalIdaVuelta, @PrecioEquipajeDeposito, @PrecioTotal, @EquipajeMano, @EquipajeDeposito, @FechaVenta)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                command.Parameters.AddWithValue("@Nacional", nacional);
                command.Parameters.AddWithValue("@IdaVuelta", idaVuelta);
                command.Parameters.AddWithValue("@PrecioBase", precioBase);
                command.Parameters.AddWithValue("@PrecioAdicionalPorKilometro", precioAdicionalPorKilometro);
                command.Parameters.AddWithValue("@PrecioAdicionalIdaVuelta", precioAdicionalIdaVuelta);
                command.Parameters.AddWithValue("@PrecioEquipajeDeposito", precioEquipajeDeposito);
                command.Parameters.AddWithValue("@PrecioTotal", precioTotal);
                command.Parameters.AddWithValue("@EquipajeMano", equipajeMano);
                command.Parameters.AddWithValue("@EquipajeDeposito", equipajeDeposito);
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
