using Entities.DataTransferObjects.AddressDto;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/Address")]
    public class AddressController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public AddressController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll/{userId:int}")]
        public async Task<IActionResult> GetAllAddressAsync([FromRoute] int userId)
        {
            var address = await _manager.AddressService.GetAllAddressAsync(userId, false);
            return Ok(address);
        }

        [HttpGet("Get/{addressId:int}")]
        public async Task<IActionResult> GetOneAddressAsync([FromRoute] int addressId)
        {
            var address = await _manager.AddressService.GetOneAddressAsync(addressId, false);
            return Ok(address);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneAddressAsync([FromBody] AddressDtoForInsertion addressDtoForInsertion)
        {
            var address = await _manager.AddressService.CreateOneAddressAsync(addressDtoForInsertion);
            return Ok(address);
        }

        [HttpPut("Update/{addressId:int}")]
        public async Task<IActionResult> UpdateOneAddressAsync([FromRoute] int addressId, [FromBody] AddressDtoForUpdate addressDtoForUpdate)
        {
            var address = await _manager.AddressService.UpdateOneAddressAsync(addressId, addressDtoForUpdate, false);
            return Ok(address);
        }

        [HttpDelete("Delete/{addressId:int}")]
        public async Task<IActionResult> DeleteOneAddressAsync([FromRoute] int addressId)
        {
            var address = await _manager.AddressService.DeleteOneAddressAsync(addressId, false);
            return Ok(address);
        }
    }
}
