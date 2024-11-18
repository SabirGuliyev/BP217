using Microsoft.AspNetCore.Mvc;

namespace MVCintro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
