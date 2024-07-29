using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Display()
        {
            return "Shahzad Display";
        }

        public int DisplayId(int Id)
        {
            return Id;
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
