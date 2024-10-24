using GenericTypeExample.Models;
using System.Collections;

namespace GenericTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Product example
            //Product product = new Product(5);
            //Product product2 = new Product('A');
            //Product product3 = new Product("High");



            //Product<int> product = new Product<int>(5);
            //Product<char> product2 = new Product<char>('A');
            //Product<string> product3 = new Product<string>("High");



            //Char.ToUpper(product2.Quality); 
            #endregion

            #region Zoo park
            //Student student = new Student { Name = "Ayxan" };

            //Lion lion = new Lion { AvgLifeTime = 20, IsPrime = true,Name="Simba" };
            //Lion lion2 = new Lion { AvgLifeTime = 20, IsPrime = false,Name="Pumba" };

            //Meat meat = new Meat {TypeName="Beef",IsHalal=true };

            //ZooCage<Lion,Meat> zooCage = new ZooCage<Lion,Meat>(meat);
            //zooCage.Add(lion);
            //zooCage.Add(lion2);

            //zooCage.ShowAnimals();

            //Console.WriteLine("--------------------------------");
            //Elephant elephant=new Elephant { AvgLifeTime=30,TeethWeigth=23,Name="Hakuna"};
            //Elephant elephant2=new Elephant { AvgLifeTime=30,TeethWeigth=23,Name="Matata"};

            //Grass grass = new Grass { TypeName = "Yonca", IsLegal = true };

            //ZooCage<Elephant,Grass> zooCage2=new ZooCage<Elephant,Grass>(grass);
            //zooCage2.Add(elephant);
            //zooCage2.Add(elephant2);

            //zooCage2.ShowAnimals();

            //Print('a', new int[0]); 
            #endregion



            //ArrayList arrayList = new ();
            //arrayList.Add('c');
            //arrayList.Add(1);
            //arrayList.Add("Salam");
            //arrayList.Add(true);
            //arrayList.Remove(1);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList  list = new SortedList();
            //list.Add(3, "Mehin");
            //list.Add("", "Mehin");
            //list.Add(3, "Mehin");





            //SortedList<string, string> students = new SortedList<string, string>();
            //students.Add("c3", "Azad");
            //students.Add("c1", "Ismayil");
            //students.Add("c2", "Ayla");

            //Console.WriteLine(students["c1"]);
            //Console.WriteLine(students.TryAdd("c4", "Ayxan"));



            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}


            //LIFO
            //Stack<string> cities = new Stack<string>();

            //cities.Push("Oslo");
            //cities.Push("Sumqayit");
            //cities.Push("Berde");
            //cities.Push("Baki");
            //cities.Push("Lenkeran");

            //Console.WriteLine(cities.Peek());
            //Console.WriteLine(cities.Peek());
            //Console.WriteLine(cities.Peek());
            //string str;

            //cities.TryPop(out str);

            //Console.WriteLine("-----------");
            //foreach (string s in cities)
            //{
            //    Console.WriteLine(s);
            //}

            //for (int i = 0; i < cities.Count; i++)
            //{
            //    Console.WriteLine(cities.ElementAt(i));
            //}



            //FIFO
            //Queue<string> names=new Queue<string>();
            //names.Enqueue("Azad");
            //names.Enqueue("Mirdavud");
            //names.Enqueue("Nicat");

            //names.Dequeue();
            //names.Dequeue();
            //names.Dequeue();

            //Console.WriteLine(names.Peek());
            //Console.WriteLine("-------------------");
            //foreach (string name in names)
            //{

            //    Console.WriteLine(name);
            //}


            // Dictionary<char,string> names= new Dictionary<char,string>();
            //names.Add('a', "Ismayil");
            //names.Add('c', "Nurane");
            //names.Add('r', "Nurane");
            //names.Add('b', "Azad");
            //Console.WriteLine(names['c']);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}



            //LinkedList
           


            List<int> nums = new List<int>();
            nums.Capacity = 40;
          
            //1 2 3 4 5             12345000 00000000     0000000000000      0000000000000000         
            //List<int> nums2 = new List<int> {10,20,30 };
            nums.Add(4);
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);


            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //nums.Contains(3);
            //nums.AddRange(nums2);
            //nums.RemoveAll(x => x < 2);


            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}


        }











        //public static void Print<T, U>(T input, U input2)
        //{
        //    Console.WriteLine(input+" "+input2);
        //}
    }
}
