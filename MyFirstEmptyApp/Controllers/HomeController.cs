using Microsoft.AspNetCore.Mvc;

namespace MyFirstEmptyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FanMail()
        {
            //write our code here

            return View();
        }

        public IActionResult CatCalculator()
        {
            return View();
        }
    }
}
