using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.AddressDto
{
    public abstract record AddressDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }
        [Required]
        public string? AddressTitle { get; init; }
        [Required]
        public string? AddressText { get; init; }
        public string? AddressCity { get; init; }
        public string? AddressDistrict { get; init; }
    }
}
