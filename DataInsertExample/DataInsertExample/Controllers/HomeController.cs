using DataInsertExample.Models;
using DataInsertExample.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DataInsertExample.Controllers
{
    public class HomeController:Controller
    {



        public IActionResult Index()
        {
            //ViewBag.Students = students;

            //ViewData["Students"] = students;

            //TempData["Name"] = "Azad";
            List<Student> students = new List<Student> {

            new Student{ Id = 1,Name="Mehin",Surname="Rahimli"},

            new Student{ Id = 2,Name="Ayxan",Surname="Mammadli"},

            new Student{ Id = 3,Name="Nurana",Surname="Valiyeva"},

            new Student{ Id = 4,Name="Azad",Surname="Ashurov"}
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher{Id=1,Name="Sabir",Salary=76543.9m},
                new Teacher{Id=2,Name="Emil",Salary=102543.9m}
            };
            

            HomeVM homeVM = new HomeVM {
            Students = students,
            Teachers = teachers
            };

            return View(homeVM);
        }

        public IActionResult Test()
        {
            string name = TempData["Name"].ToString();

            TempData.Keep("Name");
            return Content(name);
        }

        public IActionResult Details()
        {
            return View();
        }

        [Route("korporativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
