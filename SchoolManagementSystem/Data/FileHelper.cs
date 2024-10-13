using System.IO;
//using System.Xml;
using Newtonsoft.Json;

namespace SchoolManagementSystem.Data
{
    public static class FileHelper
    {
        public static void SaveToFile<T>(string fileName, List<T> data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        public static List<T> LoadFromFile<T>(string fileName)
        {
            if (!File.Exists(fileName))
                return new List<T>();

            var json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
