using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
