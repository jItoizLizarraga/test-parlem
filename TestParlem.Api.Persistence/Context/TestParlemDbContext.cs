using Microsoft.EntityFrameworkCore;
using TestParlem.Api.Domain.Entities;
using TestParlem.Api.Persistence.Contracts.Context;

namespace TestParlem.Api.Persistence.Context
{
    public class TestParlemDbContext : DbContext, IDbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestParlemDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var customerBuilder = modelBuilder.Entity<Customer>();

            customerBuilder.HasKey(c => c.Id);
            customerBuilder.HasMany(c => c.Products)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId)
                .IsRequired();

            var productBuilder = modelBuilder.Entity<Product>();
            productBuilder.HasKey(p => p.Id);
        }
    }
}
