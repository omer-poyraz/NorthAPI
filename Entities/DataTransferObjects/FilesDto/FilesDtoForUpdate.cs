using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.FilesDto
{
    public record FilesDtoForUpdate : FilesDtoForManipulation
    {
        [Required]
        public int FilesId { get; set; }
    }
}
