using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace HomeWork
{
    internal class Program
    {
        public static string Path = "C:\\Users\\sabir\\OneDrive\\Рабочий стол\\HomeWork\\HomeWork\\Files\\names.json";
        static void Main(string[] args)
        {

            Add("Mehin", Path);
            Add("Nici", Path);
            Add("Padawan", Path);

            Console.WriteLine(Search(" padawAn", Path)); 

            Delete(1, Path);  
        }
        public static void Add(string name,string path)
        {
            List<string> names = Deserialize(path);
            names.Add(name);
            Serialize(path, names);

        }
        public static void Delete(int index,string path)
        {
            List<string> names = Deserialize(path);
            names.RemoveAt(index);
            Serialize(path, names);
        }
        public static bool Search(string name,string path)
        {
            return Deserialize(path).Any(n=>n.Trim().ToLower()==name.Trim().ToLower());
        }

        public static List<string> Deserialize(string path)
        {
            string result;
            using (StreamReader sr = new(path))
            {
                result = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<string>>(result);
        }
        public static void Serialize(string path,List<string> names)
        {
            string outPut = JsonConvert.SerializeObject(names);
            using (StreamWriter sw = new(path))
            {
                sw.Write(outPut);
            }
        }
    }
}
