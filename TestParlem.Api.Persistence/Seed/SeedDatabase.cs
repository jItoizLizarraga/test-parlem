using TestParlem.Api.Domain.Entities;
using TestParlem.Api.Persistence.Contracts.Context;

namespace TestParlem.Api.Persistence.Seed
{
    public static class SeedDatabase
    {
        public static async Task SeedAsync(this IDbContext context)
        {
            var customers = GetCustomers();
            var products = GetProducts();

            await context.Customers.AddRangeAsync(customers);
            await context.Products.AddRangeAsync(products);

            await context.SaveChangesAsync();
        }

        public static IList<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 555555,
                    DocType = "nif",
                    DocNum = "11223344EE",
                    Email = "it@parlem.com",
                    CustomerId = "11111",
                    GivenName = "Enriqueta",
                    FamilyName1 = "Parlem",
                    Phone = "668668668"
                }
            };
        }

        public static IList<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 111111,
                    ProductName = "FIBRA 1000 ADAMO",
                    ProductTypeName = "ftth",
                    TerminalNumber = 933933933,
                    SoldAt = new DateTimeOffset(2019,01,09,0,14,26,17,new TimeSpan(0)),
                    CustomerId = 555555,
                },
                new Product
                {
                    Id = 111112,
                    ProductName = "Linea Movil",
                    ProductTypeName = "lm",
                    TerminalNumber = 933933933,
                    SoldAt = new DateTimeOffset(2019,01,09,0,14,26,17,new TimeSpan(0)),
                    CustomerId = 555555,
                }
            };
        }
    }
}
