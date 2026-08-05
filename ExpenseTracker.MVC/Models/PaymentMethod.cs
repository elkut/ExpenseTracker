using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; }
        [StringLength(10)]
        public string Type { get; }
    }
}
