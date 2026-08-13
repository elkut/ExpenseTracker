using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.MVC.Area.Expense.Controllers
{
    [Area("Expense")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View();
        }
    }
}
