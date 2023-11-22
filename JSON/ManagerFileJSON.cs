using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SerializarDeserializar
{
    /// <summary>
    /// Clase de utilidad para la operación de deserialización desde un archivo JSON.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a deserializar (T Generico).</typeparam>
    public class ManagerFileJSON<T>
    {
        private static StreamReader? reader;

        /// <summary>
        /// Deserializa el contenido de un archivo JSON y devuelve una lista de objetos del tipo pasado.
        /// </summary>
        /// <param name="pathFile">Ruta del archivo JSON.</param>
        /// <returns>Lista de objetos deserializados.</returns>
        public static List<T> Deserializar(string pathFile)
        {
            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, pathFile);
                List<T>? lista = new List<T>();

                using (ManagerFileJSON<T>.reader = new StreamReader(path))
                {
                    string jsonString = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<T>>(jsonString);
                }

                return lista ?? new List<T>();
            }
            catch (Exception ex)
            {
                // Manejar excepciones específicas o registrar el error según las necesidades de tu aplicación.
                Console.WriteLine($"Error al deserializar el archivo JSON: {ex.Message}");
                return new List<T>();
            }
        }
    }
}
