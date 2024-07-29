using Microsoft.AspNetCore.Mvc;

namespace AspActions.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public int DisplayId(int Id)
        {
            return Id;
        }
    }
}
