using Microsoft.AspNetCore.Mvc;
using ModelsInAspCore.Models;
using System.Diagnostics;

namespace ModelsInAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var students = new List<StudentModel>
            { 
                new StudentModel { rollNumber=1, Name="Shahzad", Gender="Male",standard=1},
                new StudentModel { rollNumber=2, Name="James", Gender="Male",standard=2},
                new StudentModel { rollNumber=3, Name="raheel", Gender="Male",standard=3},

            };

            ViewData["mystudent"] = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
