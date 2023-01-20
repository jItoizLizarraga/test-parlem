using Microsoft.EntityFrameworkCore;
using TestParlem.Api.Domain.Entities;

namespace TestParlem.Api.Persistence.Contracts.Context
{
    public interface IDbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
