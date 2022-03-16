using Microsoft.AspNetCore.Mvc;
using Web2._2.Services;

namespace Web2._2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Manual(int a, int b, Operation? operation = null)
        {
            switch (operation)
            {
                case Operation.Add:
                    ViewData["Result"] = CalcService.Add(a, b);
                    break;
                case Operation.Sub:
                    ViewData["Result"] = CalcService.Sub(a, b);
                    break;
                case Operation.Mult:
                    ViewData["Result"] = CalcService.Mult(a, b);
                    break;
                case Operation.Div:
                    ViewData["Result"] = CalcService.Div(a, b);
                    break;
            }
            return View();
        }

        public IActionResult ManualWithSeparateHandlers(int a, int b, Operation? operation = null)
        {
            switch (operation)
            {
                case Operation.Add:
                    return Act_Add(a, b);
                case Operation.Sub:
                    return Act_Sub(a, b);
                case Operation.Mult:
                    return Act_Mult(a, b);
                case Operation.Div:
                    return Act_Div(a, b);
                default:
                    return View();
            }
        }

        private IActionResult Act_Add(int a, int b)
        {
            ViewData["Result"] = CalcService.Add(a, b);
            return View();
        }

        private IActionResult Act_Sub(int a, int b)
        {
            ViewData["Result"] = CalcService.Sub(a, b);
            return View();
        }

        private IActionResult Act_Mult(int a, int b)
        {
            ViewData["Result"] = CalcService.Mult(a, b);
            return View();
        }

        private IActionResult Act_Div(int a, int b)
        {
            ViewData["Result"] = CalcService.Div(a, b);
            return View();
        }

        public IActionResult ModelBindingInParameters()
        {
            return View();
        }

        public IActionResult ModelBindingInSeparateModel()
        {
            return View();
        }
    }
}
