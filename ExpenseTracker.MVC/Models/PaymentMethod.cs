using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.MVC.Models
{
    public class PaymentMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(15)]
        public string Type { get; set; } = "";

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
