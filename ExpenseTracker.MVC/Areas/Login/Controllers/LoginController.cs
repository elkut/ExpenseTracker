using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.MVC.Area.Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
