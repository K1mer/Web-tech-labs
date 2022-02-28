using Microsoft.AspNetCore.Mvc;
using Web2._1.Models;

namespace Web2._1.Controllers
{
    public class CalcServiceController : Controller
    {
        private Random random = new Random();
        public IActionResult PassUsingViewBag()
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            ViewBag.a = a; ViewBag.b = b;

            ViewBag.Add = a + b;
            ViewBag.Sub = a - b;
            ViewBag.Mult = a * b;
            ViewBag.Div = b != 0 ? (a / b).ToString() : "Infinity";

            return View();
        }

        public IActionResult PassUsingViewData()
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            ViewData["a"] = a;
            ViewData["b"] = b;

            ViewData["Add"] = a + b;
            ViewData["Sub"] = a - b;
            ViewData["Mult"] = a * b;
            ViewData["Div"] = b != 0 ? (a / b) : "Infinity";

            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            CalcDataModel data = new(a, b);

            return View(data);
        }
    }
}
