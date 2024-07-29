using Microsoft.AspNetCore.Mvc;

namespace WebDataAndBag.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
