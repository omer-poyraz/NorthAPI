using Entities.Models;

namespace Entities.DataTransferObjects.ProductDto
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        public int CategoryId { get; init; }
        public string? ProductName { get; init; }
        public string? ProductDesc { get; init; }
        public int ProductStar { get; init; }
        public decimal Price { get; init; }
        public Category? Category { get; init; }
        public ICollection<Files>? Files { get; set; }
    }
}
