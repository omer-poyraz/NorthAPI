namespace Entities.Models
{
    public class Basket
    {
        //Aynı ürünü farklı zamanda eklerse ne yapcan
        public int BasketId { get; set; }
        public int UserId { get; set; }
        public int ProductLength { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
