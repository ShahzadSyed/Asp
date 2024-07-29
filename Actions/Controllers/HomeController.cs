using Microsoft.AspNetCore.Mvc;

namespace Actions.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
