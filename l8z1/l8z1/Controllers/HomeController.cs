using l8z1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace l8z1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyPage()
        {
            ViewBag.Message = "My first page in MVC";
            ViewBag.ValueX = 1234;
            ViewBag.ValueText = "text value";
            return View();
        }
        public IActionResult MyPage2(int number, string name, string other)
        {
            ViewBag.Message = "Parametric page number=" + number + " name=" +
            name + " , other=" + other;
            return View("MyPage");
        }
    }
}
