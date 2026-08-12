using ExpenseTracker.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.MVC.Data
{
    public class ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : DbContext(options)
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().ToTable("Expense");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");

            base.OnModelCreating(modelBuilder);
        }
    }
}
