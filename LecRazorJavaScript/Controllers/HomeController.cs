using LecRazorJavaScript.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LecRazorJavaScript.Controllers
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
            ViewData["SomeValue1"] = "From the controller 1";
            ViewBag.SomeValue2 = "From the controller 2";
            return View();
        }

        public IActionResult PersonVMDemo()
        {
            return View();
        }

        public IActionResult JavaScript1()
        {
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