namespace ExpenseTracker.MVC.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public required string StreetName { get; set; }
        public string? UnitNumber { get; set; }
        public required string City { get; set; }
        public required string Province { get; set; }

    }
}
