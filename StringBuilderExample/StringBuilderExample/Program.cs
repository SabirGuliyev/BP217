using System.Security.Cryptography;
using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = "hello";
            //string word2 = word;

            //word2 += " world";

            //Console.WriteLine(word);
            //for (int i = 0; i < 100; i++)
            //{
            //    word += "a";
            //    Console.WriteLine(word);
            //}



            //word.Trim()
            //word.ToLower()
            //word.ToUpper()
            //word.Replace(" ","")
            //word.Contains("salam")
            //word.StartsWith("Salam")
            //word.EndsWith()
            //word.IndexOf('a')
            //word.LastIndexOf('a')

            //word.ToCharArray();



            //string[] arr = { "Salam", "Gencler", "Necesiz" };
            //string.Join(" ", arr)


            // string sentence = "Salam Gencler Necesiz";
            //string[] arr2= sentence.Split("en");

            // for(int i = 0; i < arr2.Length; i++)
            // {
            //     Console.WriteLine(arr2[i]);
            // }
            //string ans =string.Empty;
            //string.Concat(ans);

            //String
            //Console.WriteLine();

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine().Trim();
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = Capitalize(name);
            }

            Console.WriteLine(name);
            //sAbiR  Sabir

            //string password = " Sabir123 ";

            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (Char.IsUpper(password[i]))
            //    {

            //    }
            //    if(Char.IsLower())

            //}


            //int[] arr = { 3, 2, 9,7,11,4,1,0 };

            //arr.Min();
            //arr.Max();
            //arr.Sum();
            //arr.Average();

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


        }


        public static string Capitalize(string name)
        {
            StringBuilder str = new StringBuilder();
            str.Append(Char.ToUpper(name[0]));
            //S

            for (int i = 1; i < name.Length; i++)
            {
                str.Append(Char.ToLower(name[i]));
            }

            return str.ToString();

        }
    }
}
