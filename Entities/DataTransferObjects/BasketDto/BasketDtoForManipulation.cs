using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.BasketDto
{
    public abstract record BasketDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }
        [Required]
        public int ProductLength { get; init; }
        [Required]
        public int ProductId { get; init; }
    }
}
