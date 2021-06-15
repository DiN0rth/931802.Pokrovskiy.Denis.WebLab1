using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebLab1.Models;


namespace WebLab1.Controllers
{
    public class HomeController : Controller
    {
        Random rand = new Random();

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

        public IActionResult PassUsingModel()
        {
            CalculationModel calc = new CalculationModel();

            calc.n1 = rand.Next(0, 10);
            calc.n2 = rand.Next(0, 10);

            calc.Plus = calc.n1 + calc.n2;
            calc.Minus = calc.n1 - calc.n2;
            calc.Multiply = calc.n1 * calc.n2;

            if (calc.n2 != 0) calc.Divide = "" + Math.Floor(calc.n1 / calc.n2);
            else calc.Divide = "Error: Division by zero";
            return View(calc);
        }

        public IActionResult PassUsingViewData()
        {
            Random rand = new Random();

            double n1 = rand.Next(0, 10);
            double n2 = rand.Next(0, 10);

            ViewData["n1"] = n1;
            ViewData["n2"] = n2;
            ViewData["Plus"] = n1 + n2;
            ViewData["Minus"] = n1 - n2;
            ViewData["Multiply"] = n1 * n2;

            if (n2 != 0) ViewData["Divide"] = "" + Math.Floor(n1 / n2);
            else ViewData["Divide"] = "Error: Division by zero";

            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            Random rand = new Random();

            double n1 = rand.Next(0, 10);
            double n2 = rand.Next(0, 10);

            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.Plus = n1 + n2;
            ViewBag.Minus = n1 - n2;
            ViewBag.Multiply = n1 * n2;

            if (n2 != 0) ViewBag.Divide = "" + Math.Floor(n1 / n2);
            else ViewBag.Divide = "Error: Division by zero";

            return View();
        }

        public IActionResult AccessServiceDirectly()
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