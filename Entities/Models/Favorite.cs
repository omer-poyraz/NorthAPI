namespace Entities.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public Product? Product { get; set; }
    }
}
