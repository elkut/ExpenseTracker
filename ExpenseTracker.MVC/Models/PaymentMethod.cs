using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Type { get; set; } = "";
    }
}
