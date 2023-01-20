using TestParlem.Api.Models.Responses;
using TestParlem.Frontend.Services.Interfaces;

namespace TestParlem.Frontend.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CustomerService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<CustomerResponse> GetCustomerAsync(int id, CancellationToken cancellationToken)
        {
            var client = _clientFactory.CreateClient("TestParlem.Api");

            var response = await client.GetAsync($"/api/Customer/{id}", cancellationToken);

            response.EnsureSuccessStatusCode();

            return await response.Content?.ReadFromJsonAsync<CustomerResponse>(cancellationToken:cancellationToken);
        }
    }
}
