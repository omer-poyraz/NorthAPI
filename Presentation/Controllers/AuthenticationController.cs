using Entities.DataTransferObjects.UserDto;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/Authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public AuthenticationController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuthenticationDto)
        {
            if (!await _manager.AuthenticationService.ValidUser(userForAuthenticationDto))
                return Unauthorized();

            var token = await _manager.AuthenticationService.CreateToken(true);
            return Ok(token);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDto userForRegisterDto)
        {
            var result = await _manager.AuthenticationService.RegisterUser(userForRegisterDto);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Ok(result);
        }
    }
}
