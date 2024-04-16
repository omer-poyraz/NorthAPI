using Entities.DataTransferObjects.OrderDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Order")]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll/{userId:int}")]
        public async Task<IActionResult> GetAllOrdersAsync([FromRoute] int userId)
        {
            var orders = await _manager.OrderService.GetAllOrdersAsync(userId, false);
            return Ok(orders);
        }

        [HttpGet("Get/{orderId:int}")]
        public async Task<IActionResult> GetOneOrderAsync([FromRoute] int orderId)
        {
            var order = await _manager.OrderService.GetOneOrderAsync(orderId, false);
            return Ok(order);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneOrderAsync([FromBody] OrderDtoForInsertion orderDtoForInsertion)
        {
            var order = await _manager.OrderService.CreateOneOrderAsync(orderDtoForInsertion);
            return Ok(order);
        }

        [HttpDelete("Delete/{orderId:int}")]
        public async Task<IActionResult> DeleteOneOrderAsync([FromRoute] int orderId)
        {
            var order = await _manager.OrderService.DeleteOneOrderAsync(orderId, false);
            return Ok(order);
        }
    }
}
