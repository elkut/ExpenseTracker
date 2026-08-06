using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.MVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string CategoryName { get; set; } = "";
    }
}
