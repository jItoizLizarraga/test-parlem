namespace TestParlem.Api.Models.Responses
{
    public class CustomerResponse
    {
        public int Id { get; set; }
        public string DocType { get; set; }
        public string DocNum { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName1 { get; set; }
        public string Phone { get; set; }
        public IEnumerable<ProductResponse> Products { get; set; }
    }
}
