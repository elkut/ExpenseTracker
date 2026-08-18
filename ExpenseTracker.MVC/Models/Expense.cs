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

        //Expense belongs to one Category
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Expense uses one PaymentMethod
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = null!;

        // Expense belongs to one User
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
