using MediatR;
using Microsoft.EntityFrameworkCore;
using TestParlem.Api.Application.Contracts.Queries.Customers;
using TestParlem.Api.Application.Mappers;
using TestParlem.Api.Models.Responses;
using TestParlem.Api.Persistence.Contracts.Context;

namespace TestParlem.Api.Application.QueryHandlers.Customers
{
    public class GetCustomerQueryHandlers : IRequestHandler<GetCustomerQuery, CustomerResponse?>
    {
        private readonly IDbContext _dbContext;

        public GetCustomerQueryHandlers(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }   

        public async Task<CustomerResponse?> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _dbContext.Customers.AsNoTracking()
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);

            return customer?.ToCustomerResponse();
        }
    }
}
