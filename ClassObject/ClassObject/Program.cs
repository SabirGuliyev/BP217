using ClassObject.Models;

namespace ClassObject
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            //object person = new
            //{
            //    Name = "Ismayil",
            //    Surname = "Ibrahimzada",
            //    Age = 19,
            //    IsSingle = true
            //};

            //Console.WriteLine(person);

            //Person person = new Person();

            //person.Name = "Ismayil";
            //person.Surname = "Ibrahimzada";
            //person.Age = 19;
            //person.IsSingle= true;


            //Person person2 = new Person
            //{
            //    name = "mehin",
            //    surname = "rahimli",
            //    age = 19,
            //    issingle = true
            //};



            //person.GetInfo();

            //person2.GetInfo();



            //Person person3 = new Person("Sabir","Guliyev",26,true);
            //Person person4 = new Person("Huseyn","Abbasov",19);
            //Person person5 = new Person("Azad","Ashurov");
            //Person person6 = new Person("Azad","Ashurov",19);



            //person6.GetInfo();




            //Console.WriteLine(person.Name+" "+person.Surname+" "+person.Age);
            ////Console.WriteLine("{0} {1} {2}",person2.Name,person2.Surname,person2.Age);
            //Console.WriteLine($"{person2.Name} {person2.Surname} {person2.Age}");

            Student student = new Student("Alya","Atakishiyeva");

            Teacher teacher = new Teacher("Sabir", "Guliyev");


            //student.GetInfo();

            //Teacher teacher = new Teacher { 
            //Name="Sabir",
            //Surname="Guliyev",
            //Age=26,
            //IsSingle=true,
            //Experience=2,
            //Profession="C#",
            //Salary=76543.90m
            
            //};


        }
    }

    
}

