using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.BasketDto
{
    public record BasketDtoForUpdate : BasketDtoForManipulation
    {
        [Required]
        public int BasketId { get; init; }
    }
}
