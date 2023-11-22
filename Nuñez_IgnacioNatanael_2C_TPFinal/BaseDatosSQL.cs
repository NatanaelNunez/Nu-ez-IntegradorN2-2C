using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    /// <summary>
    /// Clase que gestiona las operaciones en una base de datos SQL para esta app.
    /// </summary>
    public class BaseDatosSQL
    {
        private readonly string connectionString;

        /// <summary>
        /// Constructor de la clase <see cref="BaseDatosSQL"/>.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos SQL.</param>
        public BaseDatosSQL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Agrega una venta a la base de datos.
        /// </summary>
        /// <param name="dni">DNI del pasajero.</param>
        /// <param name="NombreCompleto">Nombre completo del pasajero.</param>
        /// <param name="nacional">Indica si el vuelo es nacional.</param>
        /// <param name="idaVuelta">Indica si es un vuelo de ida y vuelta.</param>
        /// <param name="precioBase">Precio base del vuelo.</param>
        /// <param name="precioAdicionalPorKilometro">Precio adicional por kilómetro.</param>
        /// <param name="precioAdicionalIdaVuelta">Precio adicional por vuelo de ida y vuelta.</param>
        /// <param name="precioEquipajeDeposito">Precio del equipaje de depósito.</param>
        /// <param name="precioTotal">Precio total de la venta.</param>
        /// <param name="equipajeMano">Cantidad de equipaje de mano.</param>
        /// <param name="equipajeDeposito">Cantidad de equipaje para depósito.</param>
        public void AgregarVenta(int dni, string NombreCompleto, bool nacional, bool idaVuelta,
            decimal precioBase, decimal precioAdicionalPorKilometro, decimal precioAdicionalIdaVuelta,
            decimal precioEquipajeDeposito, decimal precioTotal, int equipajeMano, int equipajeDeposito)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar venta: {ex.Message}");
                // excepción 
            }
        }

        /// <summary>
        /// Obtiene la lista de viajes vendidos desde la base de datos.
        /// </summary>
        /// <returns>Lista de viajes vendidos.</returns>
        public List<ViajeVendido> ObtenerViajesVendidos()
        {
            List<ViajeVendido> viajes = new List<ViajeVendido>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ViajeID, DNI, NombreCompleto, Nacional, EquipajeMano, EquipajeDeposito, " +
                        "PrecioBase, PrecioAdicionalPorKilometro, PrecioAdicionalIdaVuelta, PrecioEquipajeDeposito, PrecioTotal, FechaVenta FROM ViajesVendidos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ViajeVendido viaje = new ViajeVendido
                                {
                                    IDViaje = Convert.ToInt32(reader["ViajeID"]),
                                    DNIPasajero = Convert.ToInt32(reader["DNI"]),
                                    NombreCompleto = Convert.ToString(reader["NombreCompleto"]),
                                    TipoVuelo = Convert.ToString(reader["Nacional"]),
                                    EquipajeMano = Convert.ToInt32(reader["EquipajeMano"]),
                                    EquipajeDeposito = Convert.ToInt32(reader["EquipajeDeposito"]),
                                    PrecioBase = Convert.ToDecimal(reader["PrecioBase"]),
                                    PrecioAdicionalxKM = Convert.ToDecimal(reader["PrecioAdicionalPorKilometro"]),
                                    PrecioAdicionalIdaVuelta = Convert.ToDecimal(reader["PrecioAdicionalIdaVuelta"]),
                                    PrecioEquipajeDeposito = Convert.ToDecimal(reader["PrecioEquipajeDeposito"]),
                                    PrecioTotal = Convert.ToDecimal(reader["PrecioTotal"]),
                                    FechadeVenta = Convert.ToDateTime(reader["FechaVenta"])
                                };

                                viajes.Add(viaje);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener viajes vendidos: {ex.Message}");
                // excepción
            }

            return viajes;
        }


        // Grid 
        /*
        public DataTable ObtenerViajesVendidos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ViajeID, DNI, NombreCompleto, Nacional, " +
                    "EquipajeMano, EquipajeDeposito, PrecioTotal, FechaVenta FROM ViajesVendidos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }*/
    }
}
