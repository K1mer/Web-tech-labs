using Microsoft.AspNetCore.Mvc;

namespace Web2._4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}