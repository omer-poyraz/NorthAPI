using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.CategoryDto
{
    public abstract record CategoryDtoForManipulation
    {
        [Required]
        public string? CategoryName { get; init; }
        public string? CategoryImg { get; init; }
    }
}
