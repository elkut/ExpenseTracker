using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Range(0, 100000)]
        public double Amount { get; set; }
        [StringLength(30)]
        public string? Merchant { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        public string? PaymentMethod { get; set; }
        public int UserID { get; set; }

        public IEnumerable<Category> Categories { get; } = [];
        public IEnumerable<PaymentMethod> PaymentMethods { get; } = new List<PaymentMethod>();
    }
}
