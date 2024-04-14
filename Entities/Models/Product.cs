namespace Entities.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDesc { get; set; }
        public int ProductStar { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public ICollection<Files>? Files { get; set; }
    }
}
