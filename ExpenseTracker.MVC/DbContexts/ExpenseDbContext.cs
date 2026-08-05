using ExpenseTracker.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.MVC.Data
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expence> Expences { get; set; }
        public DbSet<Category> Categories { get; }
        public DbSet<PaymentMethod> PaymentMethods { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expence>().ToTable("Expence");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
        }
    }
}
