using Microsoft.AspNetCore.Mvc;

namespace MVCintro.Controllers
{
    public class HomeController:Controller
    {



        public IActionResult Index()
        {



            return View();

            //var student = new JsonResult(
            //    new
            //    {
            //        Id = 1,
            //        Name = "Mehin",
            //        Surname = "Rahimli"
            //    }
            //    );

            //return student;
        }

        public IActionResult Detail(int? id)
        {
            if(id is null || id < 1)
            {
                return RedirectToAction(nameof(Error));
            }
            return View("Product");
        }

        public IActionResult Error()
        {
           
            return View();
        }
    }
}
