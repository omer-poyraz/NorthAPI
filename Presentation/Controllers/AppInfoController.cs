using Entities.DataTransferObjects.AppInfoDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/AppInfo")]
    public class AppInfoController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public AppInfoController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAppInfosAsync()
        {
            var appInfo = await _manager.AppInfoService.GetAllAppInfosAsync(false);
            return Ok(appInfo);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetOneAppInfoAsync([FromRoute] int id)
        {
            var appInfo = await _manager.AppInfoService.GetOneAppInfoAsync(id, false);
            return Ok(appInfo);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneAppInfoAsync([FromBody] AppInfoDtoForInsertion infoDtoForInsertion)
        {
            var appInfo = await _manager.AppInfoService.CreateOneAppInfoAsync(infoDtoForInsertion);
            return Ok(appInfo);
        }

        [HttpPut("Update/{id:int}")]
        public async Task<IActionResult> UpdateOneAppInfoAsync([FromRoute] int id, [FromBody] AppInfoDtoForUpdate infoDtoForUpdate)
        {
            var appInfo = await _manager.AppInfoService.UpdateOneAppInfoAsync(id, infoDtoForUpdate, false);
            return Ok(appInfo);
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> DeleteOneAppInfoAsync([FromRoute] int id)
        {
            var appInfo = await _manager.AppInfoService.DeleteOneAppInfoAsync(id, false);
            return Ok(appInfo);
        }
    }
}
