using System.Security.Cryptography;
using UpcastingDowncastingImplicit.Exchanges;
using UpcastingDowncastingImplicit.Models;

namespace UpcastingDowncastingImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting Downcasting
            //int age = 450;
            //byte age2 = (byte)age;
            //Console.WriteLine(age2);

            //Eagle eagle2 = new Eagle {AvgLifeTime=20,FlySpeed=100,Gender="Female" };
            //Dog dog = new Dog {AvgLifeTime=20,Gender="Male",Breed="Golden retriever",Name="Tedd" };

            //object test = eagle2;
            //implicit casting
            //Animal animal = new Dog { AvgLifeTime = 10, Gender = "Male", Breed = "American pocket bully", Name = "Maximus Prime" };
            //Animal animal2 = eagle;
            ////explicit casting
            //Dog dog2 = (Dog)animal2;



            //Console.WriteLine(dog2.Name);


            //Animal[] zoo = { eagle2, dog };
            //foreach (Animal animal in zoo)
            //{ 
            //Casting with Explicit operator
            //    //Eagle eagle2 = (Eagle)animal;
            //    //eagle2.Fly();

            //Casting with As operator
            //    //Eagle eagle=animal as Eagle;
            //    //if(eagle !=null)
            //    //{
            //    //    eagle.Fly();
            //    //}

            //Casting with is operator(is is not casting operator!!)
            //    //if (animal is Eagle eagle)
            //    //{

            //    //   eagle.Fly();
            //    //}


            //} 
            #endregion

            #region Boxing Unboxing
            ////Boxing
            //int a = 5;
            //object b = a;

            //Test test = new Test();
            ////object d = test;

            //ITestable testable = test;
            ////Unboxing
            //int c =(int) b; 
            #endregion

            #region Implicit Explicit and Operator overload

            ////Dollar dollar = new Dollar(134);
            //Manat manat = new Manat(500);


            //Manat manat2 = (Manat)dollar;
            ////Dollar dollar2 = (Dollar)manat;


            //Manat manat3 = 300m;
            //Console.WriteLine(dollar2.USD);



            //Manat manat = new Manat(200m);
            //Manat manat2 = new Manat(300m);


            //manat = manat + manat2;
            //manat += manat;

            //manat += 200m;

            //Console.WriteLine(manat);
            //Console.WriteLine(manat>manat2); 
            #endregion

            var date = DateTime.Now;
            Console.WriteLine(date);
            //date=date.AddHours(4);
            //Console.WriteLine(date);
            if (true)
            {
                for (int i = 0; i < 10000; i++)
                {
                    Dog dog = new Dog { Name="Max"};
                }
               
            }
           
            //GC.SuppressFinalize();


            for (int i = 0; i < 100000; i++)
            {
                Dog dog = new Dog { Name = "Max" };

            }
            Console.Read();
        }

    }
    //public struct Test:ITestable
    //{
    //    public int x;

    //    public int Y { get ; set ; }
    //}
    //public interface ITestable
    //{
    //    public int Y { get; set; }
    //}
}
