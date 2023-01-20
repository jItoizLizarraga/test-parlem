using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TestParlem.Api.Application.Contracts.Queries.Products;
using TestParlem.Api.Models.Responses;

namespace TestParlem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductResponse), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get([FromRoute, BindRequired] int id, CancellationToken cancellationToken)
        {
            var query = new GetProductQuery(id);

            var result = await _mediator.Send(query, cancellationToken);

            if (!result.Any())
                return NotFound();
            else
                return Ok(result.FirstOrDefault());
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<ProductResponse>), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetProductQuery();

            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
