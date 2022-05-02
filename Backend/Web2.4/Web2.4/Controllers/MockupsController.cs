using Microsoft.AspNetCore.Mvc;
using Web2._4.Services;

namespace Web2._3.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reset()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string FirstName, string LastName, 
            string Birthday_Day, string Birthday_Month, string Birthday_Year,
            string Gender)
        {

            if (!ModelState.IsValid) return View();



            Dictionary<string, string> data = new()
            {
                ["FirstName"] = FirstName,
                ["LastName"] = LastName,
                ["Birthday_Day"] = Birthday_Day,
                ["Birthday_Month"] = Birthday_Month,
                ["Birthday_Year"] = Birthday_Year,
                ["Gender"] = Gender
            };

            AccountService.SetAccountUserInfo(data);

            return View("SignUpNext");
        }

        public IActionResult SignUpCredentials(string Email, 
            string Password, string ConfirmPassword,
            string Remember)
        {
            if (!string.Equals(Password, ConfirmPassword)) return View("SignUpNext");
            if (!ModelState.IsValid) return View("SignUpNext");

            Dictionary<string, string> data = new()
            {
                ["Email"] = Email,
                ["Password"] = Password,
                ["Remember"] = Remember
            };

            AccountService.SetAccountLoginInfo(data);

            Dictionary<string, string> UserInfo = AccountService.GetAccountUserInfo();

            ViewData["FirstName"]   = UserInfo["FirstName"];
            ViewData["LastName"]    = UserInfo["LastName"];
            ViewData["BirthDay"] = $"{UserInfo["Birthday_Day"]} {UserInfo["Birthday_Month"]} {UserInfo["Birthday_Year"]}";
            ViewData["Email"] = Email;
            ViewData["Password"] = Password;

            return View();
        }

        [HttpPost]
        public IActionResult Reset(string Email, string Action)
        {
            int All, Good = 0, Bad = 404;

            if (string.IsNullOrEmpty(Email)) All = Bad;
            else All = Good;

            if (Action == "Send me a code") { string toDo = "Send him a code!"; }

            return View("ResetNext");
        }
    }
}