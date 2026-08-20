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
            base.OnModelCreating(modelBuilder);

            const int leaseCategoryId = 1;
            const int creditCardPaymentMethodId = 1;
            var seededUserId = new Guid("d3280532-7956-4abf-9a82-e15d67f09125");
            var seededExpenseId = new Guid("d3280532-7956-4abf-9a82-e15d67f09dd8");

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = leaseCategoryId,
                        CategoryName = "Lease"
                    }
                );

            modelBuilder.Entity<PaymentMethod>()
                .HasData(
                    new PaymentMethod
                    {
                        Id = creditCardPaymentMethodId,
                        Type = "Credit Card"
                    }
                );

            modelBuilder.Entity<User>()
                .HasData(
                     new User
                     {
                         Id = seededUserId,
                         FirstName = "Alkut",
                         LastName = "Askar",
                         UserName = "AlkutAskar",
                         Email = "elkut.esker@gmail.com"
                     }
                 );

            modelBuilder.Entity<Expense>()
                .HasData(
                    new Expense
                    {
                        Id = seededExpenseId,
                        Date = new DateTime(2026, 8, 17, 0, 0, 0, DateTimeKind.Utc),
                        Amount = 350.98,
                        Merchant = "Nissan",
                        Description = "Vehicle Lease Monthly Payment",
                        PaymentMethodId = creditCardPaymentMethodId,
                        CategoryId = leaseCategoryId,
                        UserId = seededUserId
                    }
                );
        }
    }
}
