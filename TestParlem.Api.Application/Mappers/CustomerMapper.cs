using TestParlem.Api.Domain.Entities;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Application.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerResponse ToCustomerResponse(this Customer customer)
        {
            return new CustomerResponse
            {
                Id = customer.Id,
                CustomerId = customer.CustomerId,
                DocNum = customer.DocNum,
                DocType = customer.DocType,
                Email = customer.Email,
                FamilyName1 = customer.FamilyName1,
                GivenName = customer.GivenName,
                Phone = customer.Phone,
                Products = customer.Products?.Select(p => p.ToProductResponse()).ToList()
            };
        }
    }
}
