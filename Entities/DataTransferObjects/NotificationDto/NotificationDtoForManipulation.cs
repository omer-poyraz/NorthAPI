using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.NotificationDto
{
    public abstract record NotificationDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }
        [Required]
        [MaxLength(100)]
        public string? NotificationTitle { get; init; }
        [Required]
        [MaxLength(300)]
        public string? NotificationDesc { get; init; }
    }
}
