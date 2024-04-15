using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.AddressDto
{
    public record AddressDtoForUpdate : AddressDtoForManipulation
    {
        [Required]
        public int AddressId { get; init; }
    }
}
