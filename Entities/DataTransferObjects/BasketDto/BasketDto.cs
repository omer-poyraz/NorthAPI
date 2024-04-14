using Entities.Models;

namespace Entities.DataTransferObjects.BasketDto
{
    public record BasketDto
    {
        //Aynı ürünü farklı zamanda eklerse ne yapcan
        public int BasketId { get; init; }
        public int UserId { get; init; }
        public int ProductLength { get; init; }
        public int ProductId { get; init; }
        public Product? Product { get; init; }
    }
}
