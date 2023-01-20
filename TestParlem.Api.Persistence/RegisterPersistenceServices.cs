using Microsoft.Extensions.DependencyInjection;
using TestParlem.Api.Persistence.Context;
using TestParlem.Api.Persistence.Contracts.Context;
using TestParlem.Api.Persistence.Seed;

namespace TestParlem.Api.Persistence
{
    public static class RegisterPersistenceServices
    {
        public static async Task<IServiceCollection> AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<TestParlemDbContext>();
            services.AddScoped<IDbContext, TestParlemDbContext>();

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<IDbContext>();
                await dbContext.SeedAsync();
            }

            return services;
        }
    }
}