using FileExample.Models;
using Newtonsoft.Json;
using System.Threading.Channels;

namespace FileExample
{
    internal class Program
    {
        public static string PathString;
        static void Main(string[] args)
        {
          

            PathString= Path.GetFullPath(Path.Combine("..","..","..","Files", "ProductsObjects.json"));

         
            #region Directory
            //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Test");

            //if (Directory.Exists(@"C:\Users\sabir\Desktop\Test"))
            //{
            //    Directory.Delete(@"C:\Users\sabir\Desktop\Test", true);
            //}



            //if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    File.Create(@"C:\Users\sabir\Desktop\Test\text.txt").Close();
            //}

            //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");

            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\sabir\Desktop\Test");

            //directory.Create();
            //Console.WriteLine(directory.Exists); 
            ////directory.Delete();

            //FileInfo fileInfo = new FileInfo(@"C:\Users\sabir\Desktop\Test\text.txt");
            //fileInfo.Create(); 
            #endregion

            #region StreamWriter and Reader
            //string path = @"C:\Users\sabir\Desktop\Test\text3.txt";



            //using (StreamWriter sw = new StreamWriter(path, true)) 
            //{
            //    sw.WriteLine("Nici");
            //    sw.WriteLine("Padawan");
            //    sw.WriteLine("Trueman");
            //}





            //string result;

            //using (StreamReader sr=new StreamReader(path))
            //{
            //    result = sr.ReadToEnd();
            //}


            //Console.WriteLine(result); 
            #endregion




            //Category category = new Category { Name="Mobile"};
            //Category category2 = new Category { Name="TV"};


            //Product product = new Product { Id = 1, Name = "Samsung s22", Price = 2000m,Category = category};
            //Product product2 = new Product { Id = 2, Name = "Xiaomi POCO", Price = 100m,Category = category};
            //Product product3 = new Product { Id = 3, Name = "Iphone 16", Price = 2500m,Category = category};

            //Product product4 = new Product { Id = 4, Name = "Toshiba", Price = 1000m,Category = category2};
            //Product product5 = new Product { Id = 5, Name = "LG QLE", Price = 2500m,Category = category2};
            //Product product6 = new Product { Id = 6, Name = "TLC", Price = 500m,Category = category2};

            //List<Product> products = new List<Product> {product,product2,product3,product4,product5,product6 };


            //string result = JsonConvert.SerializeObject(products);


            //string path = @"C:\Users\sabir\OneDrive\Рабочий стол\FileExample\FileExample\Files\ProductsObjects.json";
            //using (StreamWriter sw = new(path,true))
            //{
            //    sw.Write(result);
            //}



            //string result;

            //using (StreamReader sr = new(path))
            //{
            //    result=sr.ReadToEnd();
            //}


            //Console.WriteLine(result);

            //List<Product> products=JsonConvert.DeserializeObject<List<Product>>(result);




            //products.Remove(products.Find(p => p.Id == 6));

            //Product search = products.Find(p => p.Id == 6);

            //products.Remove(search);

            //products.Add(new Product { Id = 20, Name = "MSI", Price = 2000m, Category = new Category { Name = "Laptop" } });

            ////products.ForEach(p => Console.WriteLine(p.Id + " " + p.Name));


            //string json = JsonConvert.SerializeObject(products);

            //using (StreamWriter sw = new(path))
            //{
            //    sw.Write(json);
            //}






            //StreamReader sr = new StreamReader(path); 

            //try
            //{
            //    Console.WriteLine(sr.ReadToEnd());

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    sr.Close();
            //}





            //StreamWriter sw = new StreamWriter(path, true);


            //sw.WriteLine("Samurai2");
            //sw.WriteLine("Mehin2");
            //sw.WriteLine("SpecialOne2");

            //sw.Close();





            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());





        }
    }
}
