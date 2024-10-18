using InterfaceExample.Humanity;
using InterfaceExample.Interfaces;
using InterfaceExample.Models;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            //Penguin penguin = new Penguin {
            //AvgLifeTime=6,
            //SwimSpeed=50,
            //Gender="male",
            //HasEgg=true

            //};

            //Eagle eagle = new Eagle { 
            //AvgLifeTime=25,
            //FlySpeed=80,
            //ClawPower=50,
            //Gender="female",
            //HasEgg=false

            //};
            //Duck duck = new Duck
            //{
            //    AvgLifeTime = 4,
            //    SwimSpeed = 20,
            //    FlySpeed = 40,
            //    Gender = "male",
            //    HasEgg = false
            //};
            //duck.Fly();
            //duck.Swim();
            //eagle.Fly();
            //penguin.Swim();
            //Plane plane=new Plane {FlySpeed=1000 };


            //IFly[] flyables = { duck, eagle,plane };
            //ISwim[] swimables = { duck, penguin };

            //foreach (var item in flyables)
            //{
            //    item.Fly();            } 
            #endregion

            Person person = new Person { Name = "Mehin", Surname = "Rahimli" };
            Person person2 = new Person { Name = "Mehin", Surname = "Rahimli" };
            Person person3 = new Person { Name = "Mehin", Surname = "Rahimli" };
            Person person4 = new Person { Name = "Mehin", Surname = "Rahimli" };


            //Person.WorkAge = 18;

            //Console.WriteLine(Person.WorkAge);


            
            //Console.WriteLine(Person.s_count);

           
           


            

        }
        
    }
}
