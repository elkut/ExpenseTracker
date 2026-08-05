using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.MVC.Area.Expenses.Controller
{
    public class ExpensesController : global::Microsoft.AspNetCore.Mvc.Controller
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
