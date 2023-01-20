using TestParlem.Api.Models.Responses;

namespace TestParlem.Frontend.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponse> GetCustomerAsync(int id, CancellationToken cancellationToken);
    }
}
