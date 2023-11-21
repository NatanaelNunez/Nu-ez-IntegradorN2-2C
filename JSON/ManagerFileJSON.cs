using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SerializarDeserializar
{
    public class ManagerFileJSON<T>
    {
        private static StreamReader? reader;

        public static List<T> Deserializar(string pathFile)
        {
            string path = Environment.CurrentDirectory + pathFile; // test + @"\datos\MOCK_DATA.json"
            List<T>? lista = new List<T>();

            using (ManagerFileJSON<T>.reader = new StreamReader(path))
            {
                string jsonString = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<T>>(jsonString);
            }

            return lista;
        }
    }
}