using TestParlem.Api.Domain.Entities;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Application.Mappers
{
    public static class ProductMapper
    {
        public static ProductResponse ToProductResponse(this Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                CustomerId = product.CustomerId,
                ProductName = product.ProductName,
                ProductTypeName = product.ProductTypeName,
                SoldAt = product.SoldAt,
                TerminalNumber = product.TerminalNumber
            };
        }
    }
}
