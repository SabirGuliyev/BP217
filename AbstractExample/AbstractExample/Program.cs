using AbstractExample.Humanity;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new()
            {
                Name = "Max",
                AvgLifeTime = 10,
                Breed = "German Shepard",
                Gender = "male"
            };


            Cow cow = new()
            {
                AvgLifeTime = 15,
                Gender = "female"
            };



            //object[] objects = {12,"Salam",'s',true,cow,dog };
           
            Animal[] farm = { cow, dog };

            //foreach(Animal item in farm)
            //{
            //    //if (false)
            //    //{
                   
            //    //}
            //    //Console.WriteLine(item.Gender);
            //}

            //for (int i = 0; i < farm.Length; i++)
            //{
            //    farm[i].MakeSound();
            //}
            //Console.WriteLine(dog);
            //Console.WriteLine(cow);






            //dog.Eat();
            //cow.Eat();



            //Animal animal = new()
            //{
            //    AvgLifeTime = 10,
            //    Gender = "male"
            //};

            //BaseEntity entity = new BaseEntity
            //{
            //    Id=
            //}



            //Student student = new Student { 
            //Name="Azad",Surname="Ashurov",Age=19,GroupName="BP217",Grade=3
            //};
            //Master master = new Master
            //{
            //    Name = "Ayxan",
            //    Surname = "Mammadli",
            //    Age = 21,
            //    GroupName = "BP217",
            //    Grade = 1,
            //    Diplom="Yuksek sheref",
            //    MasterUni="AzTU"
            //};
            //Console.WriteLine(student.GetInfo());
            ////Console.WriteLine(master);

        }


        
    }
}
