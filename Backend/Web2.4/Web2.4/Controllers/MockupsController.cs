using Microsoft.AspNetCore.Mvc;

namespace Web2._3.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Reset()
        {
            return View();
        }
    }
}