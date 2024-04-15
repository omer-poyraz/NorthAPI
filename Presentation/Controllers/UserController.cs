using Entities.DataTransferObjects.UserDto;
using Entities.RequestFeature;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/User")]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public UserController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllUsersAsync([FromQuery] UserParameters userParameters)
        {
            var users = await _manager.UserService.GetAllUsersAsync(userParameters, false);
            return Ok(users.userDtos);
        }

        [HttpGet("Get/{userId:int}")]
        public async Task<IActionResult> GetOneUserByIdAsync([FromRoute] int userId)
        {
            var user = await _manager.UserService.GetOneUserByIdAsync(userId, false);
            return Ok(user);
        }

        [HttpPut("Update/{userId:int}")]
        public async Task<IActionResult> UpdateOneUserAsync([FromRoute] int userId, [FromBody] UserDtoForUpdate userDtoForUpdate)
        {
            var user = await _manager.UserService.UpdateOneUserAsync(userId, userDtoForUpdate, false);
            return Ok(user);
        }

        [HttpDelete("Delete/{userId:int}")]
        public async Task<IActionResult> DeleteOneUserAsync([FromRoute] int userId)
        {
            var user = await _manager.UserService.DeleteOneUserAsync(userId, false);
            return Ok(user);
        }

        [HttpPut("ChangePassword/{userId:int}")]
        public async Task<IActionResult> ChangePaswordAsync([FromRoute] int userId, [FromBody] UserDtoForChangePassword changePassword)
        {
            var user = await _manager.UserService.ChangePasswordAsync(userId, changePassword.CurrentPassword!, changePassword.NewPassword!, false);
            return Ok(user);
        }
    }
}
