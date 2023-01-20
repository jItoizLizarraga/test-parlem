using MediatR;
using Microsoft.EntityFrameworkCore;
using TestParlem.Api.Application.Contracts.Queries.Products;
using TestParlem.Api.Application.Mappers;
using TestParlem.Api.Models.Responses;
using TestParlem.Api.Persistence.Contracts.Context;

namespace TestParlem.Api.Application.QueryHandlers.Products
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, IEnumerable<ProductResponse>>
    {
        private readonly IDbContext _dbContext;

        public GetProductQueryHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductResponse>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var query = _dbContext.Products.AsNoTracking()
                .Select(p => p.ToProductResponse());

            if (request.Id.HasValue)
                query.Where(p => p.Id == request.Id.Value);

            return await query.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
