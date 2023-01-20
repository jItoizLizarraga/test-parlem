using System.ComponentModel.DataAnnotations;

namespace TestParlem.Frontend.Pages
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductTypeName { get; set; }
        public int TerminalNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset SoldAt { get; set; }
        public int CustomerId { get; set; }

    }
}
