using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.AppInfoDto
{
    public record AppInfoDtoForUpdate : AppInfoDtoForManipulation
    {
        [Required]
        public int InfoId { get; init; }
    }
}
