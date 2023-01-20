using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestParlem.Frontend.Pages;
using TestParlem.Frontend.Services.Interfaces;
using TestParlem.Frontend.Services.Mappers;

namespace TestParlem.Frontend.Pages
{
    public class IndexModel : PageModel
    { 
        private readonly ICustomerService _customerService;

        [BindProperty(SupportsGet = true)]
        public CustomerViewModel Customer { get; set; }

        public IndexModel(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        public async Task OnGetAsync(CancellationToken cancellation)
        {
            var result = await _customerService.GetCustomerAsync(555555, cancellation);

            Customer = result.ToCustomerViewModel();
        }
    }
}