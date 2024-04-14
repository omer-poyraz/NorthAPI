using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.ProductDto
{
    public record ProductDtoForUpdate : ProductDtoForManipulation
    {
        [Required]
        public int ProductId { get; set; }
    }
}
