using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.MVC.Area.Expense.Controllers
{
    [Area("Expense")]
    public class ExpenseController : Controller
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
