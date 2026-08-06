using ExpenseTracker.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.MVC.Data
{
    public class ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : DbContext(options)
    {
        public DbSet<Expence> Expences { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expence>().ToTable("Expence");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");

            base.OnModelCreating(modelBuilder);
        }
    }
}
