using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.UserDto
{
    public record UserDtoForUpdate : UserDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }
    }
}
