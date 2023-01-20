using TestParlem.Api.Models.Responses;
using TestParlem.Frontend.Pages;

namespace TestParlem.Frontend.Services.Mappers
{
    public static class ProductResponseMapper
    {
        public static ProductViewModel ToProductViewModel(this ProductResponse product)
        {
            return new ProductViewModel
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
