using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.AppInfoDto
{
    public abstract record AppInfoDtoForManipulation
    {
        [Required]
        public int InfoContentId { get; set; }
        [Required]
        public string? InfoTitle { get; set; }
        [Required]
        public string? InfoContent { get; set; }
    }
}
