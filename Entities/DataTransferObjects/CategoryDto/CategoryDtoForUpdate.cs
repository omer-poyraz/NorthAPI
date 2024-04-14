using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.CategoryDto
{
    public record CategoryDtoForUpdate : CategoryDtoForManipulation
    {
        [Required]
        public int CategoryId { get; init; }
    }
}
