using Entities.Models;

namespace Entities.DataTransferObjects.FavoriteDto
{
    public record FavoriteDto
    {
        public int FavoriteId { get; init; }
        public int ProductId { get; init; }
        public int UserId { get; init; }
        public Product? Product { get; init; }
    }
}
