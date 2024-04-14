using Entities.DataTransferObjects.BasketDto;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/Basket")]
    public class BasketController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public BasketController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll/{userId:int}")]
        public async Task<IActionResult> GetAllBasketsAsync([FromRoute] int userId)
        {
            var basket = await _manager.BasketService.GetAllBasketsAsync(userId, false);
            return Ok(basket);
        }

        [HttpGet("Get/{basketId:int}")]
        public async Task<IActionResult> GetOneBasketAsync([FromRoute] int basketId)
        {
            var basket = await _manager.BasketService.GetOneBasketAsync(basketId, false);
            return Ok(basket);
        }

        [HttpPost("Create/")]
        public async Task<IActionResult> CreateOneBasketAsync([FromBody] BasketDtoForInsertion basketDtoForInsertion)
        {
            var basket = await _manager.BasketService.CreateOneBasketAsync(basketDtoForInsertion);
            return Ok(basket);
        }

        [HttpPut("Update/{basketId:int}")]
        public async Task<IActionResult> UpdateOneBasketAsync([FromRoute]int basketId, [FromBody] BasketDtoForUpdate basketDtoForUpdate) 
        {
            var basket = await _manager.BasketService.UpdateOneBasketAsync(basketId, basketDtoForUpdate, false);
            return Ok(basket);
        }

        [HttpDelete("Delete/{basketId:int}")]
        public async Task<IActionResult> DeleteOneBasketAsync([FromRoute] int basketId)
        {
            var basket = await _manager.BasketService.DeleteOneBasketAsync(basketId, false);
            return Ok(basket);
        }
    }
}
