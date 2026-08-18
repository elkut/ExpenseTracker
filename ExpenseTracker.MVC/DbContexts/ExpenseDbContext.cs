using ExpenseTracker.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.MVC.Data
{
    public class ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : DbContext(options)
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .HasData(
                new Expense
                {
                    Id = Guid.NewGuid(),
                    Date = new DateTime(2026, 08, 17),
                    Amount = 350.98,
                    Merchant = "Nissan",
                    Description = "Vehicle Lease Monthly Payment",
                    PaymentMethodId = 1,
                    CategoryId = 1
                });
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        CategoryName = "Groceries"
                    }
                );
            modelBuilder.Entity<PaymentMethod>()
                .HasData(
                    new PaymentMethod
                    {
                        Id = 1,
                        Type = "Credit Card"
                    }
                );

            modelBuilder.Entity<User>().ToTable("User");

            base.OnModelCreating(modelBuilder);
        }
    }
}
