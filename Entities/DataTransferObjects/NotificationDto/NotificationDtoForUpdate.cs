using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.NotificationDto
{
    public record NotificationDtoForUpdate : NotificationDtoForManipulation
    {
        [Required]
        public int NotificationId { get; set; }
    }
}
