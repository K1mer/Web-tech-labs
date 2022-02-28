using Microsoft.AspNetCore.Mvc;
using Web2._1.Models;

namespace Web2._1.Controllers
{
    public class CalcServiceController : Controller
    {
        private Random random = new Random();
        public IActionResult PassUsingViewBag(Services.CalcService calcService)
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            ViewBag.a = a; ViewBag.b = b;

            ViewBag.Add = calcService.Add(a, b);
            ViewBag.Sub = calcService.Sub(a, b);
            ViewBag.Mult = calcService.Mult(a, b);
            ViewBag.Div = calcService.Div(a, b);

            return View();
        }

        public IActionResult PassUsingViewData(Services.CalcService calcService)
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            ViewData["a"] = a;
            ViewData["b"] = b;

            ViewData["Add"] = calcService.Add(a, b);
            ViewData["Sub"] = calcService.Sub(a, b);
            ViewData["Mult"] = calcService.Mult(a, b);
            ViewData["Div"] = calcService.Div(a, b);

            return View();
        }

        public IActionResult PassUsingModel()
        {
            int a = random.Next() % 11;
            int b = random.Next() % 11;

            CalcDataViewModel data = new(a, b);

            return View(data);
        }

        //public IActionResult AccessServiceDirectly()
        //{
        //    return View();
        //}
    }
}
