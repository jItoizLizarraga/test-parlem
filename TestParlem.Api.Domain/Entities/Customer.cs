namespace TestParlem.Api.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string DocType { get; set; }
        public string DocNum { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName1 { get; set; }
        public string Phone { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
