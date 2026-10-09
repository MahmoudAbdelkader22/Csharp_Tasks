using Microsoft.AspNetCore.Mvc;
using MVC_Day01.Models;
using System.Diagnostics;

namespace MVC_Day01.Controllers
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
            return View();
        }
        public string ShowMsg()
        {
            return "Hello World";
        }

        public IActionResult Hello()
        {
            return Content("Hello from MVC!");
        }

        public IActionResult Product(int id)
        {
            return Content($"Product ID: {id}");
        }

        public IActionResult ProductDetails(int id)
        {
            return Json(new
            {
                Id = id,
                Name = "Laptop",
                Price = 25000
            });
        }

        public IActionResult NotFoundDemo()
        {
            return NotFound("Product not found!");
        }


        public ViewResult ShowView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }


        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 1)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello World");
            }
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
