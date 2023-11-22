using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace SerializarDeserializar
{
    public class ManagerFileXMLPasajeros
    {
        private static StreamReader? reader;

        /// <summary>
        /// Serializa una lista de pasajeros y la guarda en un archivo XML.
        /// </summary>
        /// <param name="pathFile">Ruta del archivo XML.</param>
        /// <param name="listaDato">Lista de pasajeros a serializar.</param>
        /// <returns>1 si la serialización fue exitosa, 0 si ocurrió un error.</returns>
        public static int Serializar(string pathFile, List<Pasajero> listaDato)
        {
            string path = Path.Combine(Environment.CurrentDirectory, pathFile);

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                    // XML más legible con el Indented
                    writer.Formatting = Formatting.Indented;

                    ser.Serialize(writer, listaDato);

                    Console.WriteLine("OK al Serializar los Datos");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar los Datos");
                return 0;
            }
        }

        /// <summary>
        /// Deserializa el contenido de un archivo XML y devuelve una lista de pasajeros.
        /// </summary>
        /// <param name="pathFile">Ruta del archivo XML.</param>
        /// <returns>Lista de pasajeros deserializada.</returns>
        public static List<Pasajero> Deserializar(string pathFile)
        {
            string path = Path.Combine(Environment.CurrentDirectory, pathFile);
            List<Pasajero>? listaDato = new List<Pasajero>();

            try
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                    listaDato = (List<Pasajero>)ser.Deserialize(reader);
                    return listaDato;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Deserializar los Datos");
                return new List<Pasajero>();
            }
        }

        /// <summary>
        /// Agrega un pasajero a la lista deserializada y vuelve a serializar la lista.
        /// </summary>
        /// <param name="pathFile">Ruta del archivo XML.</param>
        /// <param name="nuevoPasajero">Pasajero a agregar.</param>
        /// <returns>Cantidad de pasajeros en la lista después de la adición.</returns>
        public static int AgregarUnPasajero(string pathFile, Pasajero nuevoPasajero)
        {
            string path = Path.Combine(Environment.CurrentDirectory, pathFile);
            List<Pasajero>? listaDato = Deserializar(path);

            listaDato.Add(nuevoPasajero);

            Serializar(path, listaDato);

            return listaDato.Count;
        }
    }
}
