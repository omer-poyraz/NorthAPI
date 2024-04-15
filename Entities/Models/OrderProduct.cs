namespace Entities.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int ProductLength { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
