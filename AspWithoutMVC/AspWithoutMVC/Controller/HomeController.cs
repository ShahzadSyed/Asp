using Microsoft.AspNetCore.Mvc;

namespace AspWithoutMVC.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
