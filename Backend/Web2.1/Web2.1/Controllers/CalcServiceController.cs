using Microsoft.AspNetCore.Mvc;

namespace Web2._1.Controllers
{
    public class CalcServiceController : Controller
    {
        public IActionResult PassUsingViewBag(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            ViewBag.a = a; ViewBag.b = b;
            ViewBag.Add = calcService.Add(a, b);
            ViewBag.Sub = calcService.Sub(a, b);
            ViewBag.Mult = calcService.Mult(a, b);
            ViewBag.Div = calcService.Div(a, b);

            return View();
        }

        public IActionResult PassUsingViewData(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            ViewData["a"] = a; ViewData["b"] = b;
            ViewData["Add"] = calcService.Add(a, b);
            ViewData["Sub"] = calcService.Sub(a, b);
            ViewData["Mult"] = calcService.Mult(a, b);
            ViewData["Div"] = calcService.Div(a, b);

            return View();
        }

        public IActionResult PassUsingModel(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            Dictionary<string, string> data = new Dictionary<string, string>();

            data["a"] = a.ToString(); data["b"] = b.ToString();
            data["Add"] = calcService.Add(a, b);
            data["Sub"] = calcService.Sub(a, b);
            data["Mult"] = calcService.Mult(a, b);
            data["Div"] = calcService.Div(a, b);

            return View(data);
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
