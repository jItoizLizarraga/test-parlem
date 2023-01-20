using MediatR;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Application.Contracts.Queries.Customers
{
    public class GetCustomerQuery : IRequest<CustomerResponse>
    {
        public GetCustomerQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
