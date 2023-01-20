using MediatR;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Application.Contracts.Queries.Products
{
    public class GetProductQuery : IRequest<IEnumerable<ProductResponse>>
    {
        public GetProductQuery(int? id = null)
        {
            Id = id;
        }

        public int? Id { get; private set; }
    }
}
