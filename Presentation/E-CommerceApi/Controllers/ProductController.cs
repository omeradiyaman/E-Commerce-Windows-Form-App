using E_Commerce.Application.Features.Mediator.Commands.ProductCommands;
using E_Commerce.Application.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
           await _mediator.Send(command);
            return Ok("Ürün Başarıyla Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return Ok("Ürün Başarıyla Silindi!");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün Başarıyla Güncellendi.");
        }
    }
}
