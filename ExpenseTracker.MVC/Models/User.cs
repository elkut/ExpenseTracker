namespace ExpenseTracker.MVC.Models
{
    public class User
    {

        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }

        public ICollection<Expense> Expenses { get; set; } = [];
    }
}
