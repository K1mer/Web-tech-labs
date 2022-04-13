using Microsoft.AspNetCore.Mvc;

namespace Web2._3.Controllers
{
    public class ControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Radio()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextBox(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpPost]
        public IActionResult TextArea(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(string Select)
        {
            ViewData["Select"] = Select;
            return View();
        }

        [HttpPost]
        public IActionResult Radio(string Month)
        {
            ViewData["Month"] = Month;
            return View();
        }

        [HttpPost]
        public IActionResult DropDownList(string Month)
        {
            ViewData["Month"] = Month;
            return View();
        }

        [HttpPost]
        public IActionResult ListBox(string Month)
        {
            ViewData["Month"] = Month;
            return View();
        }
    }
}