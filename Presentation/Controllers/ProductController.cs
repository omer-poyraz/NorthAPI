using Entities.DataTransferObjects.ProductDto;
using Entities.RequestFeature;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Text.Json;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllProductsAsync([FromQuery] ProductParameters productParameters)
        {
            var products = await _manager.ProductService.GetAllProductsAsync(productParameters, false);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(products.metaData));
            return Ok(products.productDtos);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetOneProductAsync([FromRoute] int id)
        {
            var product = await _manager.ProductService.GetOneProductAsync(id, false);
            return Ok(product);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneProductAsync([FromBody] ProductDtoForInsertion productDtoForInsertion)
        {
            var product = await _manager.ProductService.CreateOneProductAsync(productDtoForInsertion);
            return Ok(product);
        }

        [HttpPut("Update/{id:int}")]
        public async Task<IActionResult> UpdateOneProductAsync([FromRoute] int id, [FromBody] ProductDtoForUpdate productDtoForUpdate)
        {
            var product = await _manager.ProductService.UpdateOneProductAsync(id, productDtoForUpdate, false);
            return Ok(product);
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> DeleteOneProductAsync([FromRoute] int id)
        {
            var product = await _manager.ProductService.DeleteOneProductAsync(id, false);
            return Ok(product);
        }
    }
}
