using TestParlem.Api.Models.Responses;
using TestParlem.Frontend.Pages;

namespace TestParlem.Frontend.Services.Mappers
{
    public static class CustomerResponseMapper
    {
        public static CustomerViewModel ToCustomerViewModel(this CustomerResponse customer)
        {
            return new  CustomerViewModel
            {
                Id = customer.Id,
                CustomerId = customer.CustomerId,
                DocNum = customer.DocNum,
                DocType = customer.DocType,
                Email = customer.Email,
                FamilyName1 = customer.FamilyName1,
                GivenName = customer.GivenName,
                Phone = customer.Phone,
                Products = customer.Products?.Select(p => p.ToProductViewModel()).ToList()
            };
        }
    }
}
