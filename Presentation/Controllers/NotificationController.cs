using Entities.DataTransferObjects.NotificationDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Notification")]
    public class NotificationController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public NotificationController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll/{userId:int}")]
        public async Task<IActionResult> GetAllNotificationsAsync([FromRoute] int userId)
        {
            var notification = await _manager.NotificationService.GetAllNotificationsAsync(userId, false);
            return Ok(notification);
        }

        [HttpGet("Get/{notificationId:int}")]
        public async Task<IActionResult> GetOneNotificationAsync([FromRoute] int notificationId)
        {
            var notification = await _manager.NotificationService.GetOneNotificationAsync(notificationId, false);
            return Ok(notification);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneNotificationAsync([FromBody] NotificationDtoForInsertion notificationDtoForInsertion)
        {
            var notification = await _manager.NotificationService.CreateOneNotificationAsync(notificationDtoForInsertion);
            return Ok(notification);
        }

        [HttpDelete("Delete/{notificationId:int}")]
        public async Task<IActionResult> DeleteOneNotificationAsync([FromRoute]int notificationId)
        {
            var notification = await _manager.NotificationService.DeleteOneNotificationAsync(notificationId, false);
            return Ok(notification);
        }
    }
}
