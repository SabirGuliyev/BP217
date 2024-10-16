//using B=NamespaceExample.Models.Base.Test;


using NamespaceExample.Education;
using System.Xml.Linq;

namespace NamespaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NamespaceExamples
            //B.Person person = new B.Person();
            //Person person = new Person("Sabir",26,"Guliyev",1);

            //person.Name = "dhfkjdfkds";
            //person.Surname = "ljhdsakjhdsal";
            //person.Id = 23;

            //Person person=new Person
            //{
            //    Age=12,
            //    Name="sabir",
            //    Surname="guliyev",
            //    Id=12
            //}
            //Console.WriteLine(person.Surname);



            //Console.WriteLine("Salam123"); 
            #endregion


            Group group = new Group("BP217");
            Group group2 = new Group("BP111");

            Student student = new Student { 
            Name="Nurane",
            Surname="Valiyeva",
            Age =19
            };
            Student student2 = new Student
            {
                Name = "Azad",
                Surname = "Ashurov",
                Age = 19
            };


           group.AddStudent(student);
           group.AddStudent(student2);
            group.AddStudent(new Student { Name = "Nicat", Surname = "Ibarhimli", Age = 19 });


            //Console.WriteLine(group.Name);
            //group.ShowStudents();


            Console.WriteLine("----------------------------");

            group2.AddStudent(new Student { Name = "Huseyn", Surname = "Abbasov", Age = 19 });
            group2.AddStudent(new Student { Name = "Mirdavud", Surname = "Mehtiyev", Age = 19 });
            group2.AddStudent(new Student { Name = "Ayxan", Surname = "Mammadli", Age = 19 });

            //Console.WriteLine(group2.Name);
            //group2.ShowStudents();

            //Student student7 = group.GetStudent("Nurane");
            //if (student7 != null)
            //{
            //    Console.WriteLine(student7.Name);
            //}



            group.RemoveStudent("Azad");
            group.ShowStudents();
            Console.WriteLine("------------");
            group.RemoveStudent("Nicat");
            group.ShowStudents();

        }
    }


}
