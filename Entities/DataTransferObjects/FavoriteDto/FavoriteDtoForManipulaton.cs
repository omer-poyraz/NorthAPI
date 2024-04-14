using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.FavoriteDto
{
    public abstract record FavoriteDtoForManipulaton
    {
        [Required]
        public int ProductId { get; init; }
        [Required]
        public int UserId { get; init; }
    }
}
