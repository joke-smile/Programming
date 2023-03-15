using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using static System.Environment;

namespace FlightsList.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации данных.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>
        /// </summary>
        static Serializer()
        {
            Path = $"{GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/FlightsList/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="flightsList">Список, который нужно сериализовать.</param>
        public static void Serialize(List<FlightInfo> flightsList)
        {
            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(flightsList));
            }
        }

        /// <summary>
        /// Реализует десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию рейсов.</returns>
        public static List<FlightInfo> Deserialize()
        {
            var flightsList = new List<FlightInfo>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    flightsList = JsonConvert.DeserializeObject
                        <List<FlightInfo>>(reader.ReadToEnd());
                }

                if (flightsList == null)
                {
                    flightsList = new List<FlightInfo>();
                }
            }
            catch
            {
                return flightsList;
            }

            return flightsList;
        }

        /// <summary>
        /// Возвращает и задаёт путь, где будут сериализоваться данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}
