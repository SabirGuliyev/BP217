using EFCore.DAL;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            //Student student = new()
            //{
            //    Name = "Ayla",
            //    Surname = "Kishiyeva",
            //    Age = 30
            //};

            //context.Students.Add(student);


            //context.SaveChanges();






            //Student student=context.Students.FirstOrDefault(s=>s.Id==4);

            //student.Name = "SpecialOne";


            //context.Students.Update(student);
            //context.Students.Remove(student);


            //context.SaveChanges();


            List<Student> students = context.Students.Where(s => s.Age < 24&& s.Name.Contains("a")).ToList();

            foreach (var item in students)
            {
                
                Console.WriteLine(item.Id + " " + item.Name);
            }


        }
    }
}
