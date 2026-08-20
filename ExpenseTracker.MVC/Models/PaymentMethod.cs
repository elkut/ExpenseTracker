using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Type { get; set; } = "";

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
