using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.ProductDto
{
    public abstract record ProductDtoForManipulation
    {
        [Required]
        public int CategoryId { get; init; }
        [Required]
        [MaxLength(50)]
        public string? ProductName { get; init; }
        [Required]
        [MaxLength(100)]
        public string? ProductDesc { get; init; }
        [Required]
        [Range(0, 5)]
        public int ProductStar { get; init; }
        [Required]
        [Range(0, 100000)]
        public decimal Price { get; init; }
    }
}
