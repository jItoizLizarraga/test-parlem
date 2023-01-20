using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TestParlem.Api.Application.Contracts.Queries.Customers;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CustomerResponse), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get([FromRoute, BindRequired] int id, CancellationToken cancellationToken)
        {
            var query = new GetCustomerQuery(id);

            var result = await _mediator.Send(query, cancellationToken);

            if (result is null)
                return NotFound();
            else
                return Ok(result);
        }
    }
}