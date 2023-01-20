using Microsoft.Extensions.DependencyInjection;
using MediatR;
using TestParlem.Api.Application.QueryHandlers.Customers;

namespace TestParlem.Api.Application
{
    public static class RegisterApplicationServices
    {
        public static IServiceCollection AddApiApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetCustomerQueryHandlers));
            return services;
        }
    }
}
