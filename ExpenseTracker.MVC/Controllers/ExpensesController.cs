using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.MVC.Controllers
{
    public class ExpensesController : Controller
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
