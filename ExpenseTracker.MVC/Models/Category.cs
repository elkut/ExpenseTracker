using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class Category
    {
        public int CategoryId { get; }
        [StringLength(25)]
        public string CategoryName { get; }
    }
}
