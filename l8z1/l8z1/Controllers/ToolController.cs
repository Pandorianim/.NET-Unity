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
    public class ToolController : Controller
    {
        private readonly ILogger<ToolController> _logger;

        public ToolController(ILogger<ToolController> logger)
        {
            _logger = logger;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Solve(int a, int b, int c)
        {
            double [] result = Program.trinomialFormula(a, b, c);
            if (result == null)
            {
                ViewBag.Style = "inf";
                ViewBag.Result = "Infinite number of sollutions";
            }
            else if (result.Length == 0)
            {
                ViewBag.Style = "no_solution";
                ViewBag.Result = "No solutions";
            }
            else if (result.Length == 1)
            {
                ViewBag.Style = "one";
                ViewBag.Result = "One sollution found: " + result[0];
            }
            else if (result.Length == 2)
            {
                ViewBag.Style = "two";
                ViewBag.Result = "Two sollution found: " + result[0] + " and " +result[1];
            }

            return View("MyPage");
        }
        
    }
}
