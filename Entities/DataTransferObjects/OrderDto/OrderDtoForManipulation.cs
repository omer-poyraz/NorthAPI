using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.OrderDto
{
    public abstract record OrderDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }
        [Required]
        public int AddressId { get; init; }
        [Required]
        public decimal OrderPrice { get; init; }
        [Required]
        public ICollection<OrderProduct>? Products { get; init; }
    }
}
