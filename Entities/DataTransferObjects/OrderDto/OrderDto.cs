using Entities.Models;

namespace Entities.DataTransferObjects.OrderDto
{
    public record OrderDto
    {
        public int OrderId { get; init; }
        public int UserId { get; init; }
        public int AddressId { get; init; }
        public decimal OrderPrice { get; init; }
        public User? User { get; init; }
        public Address? Address { get; init; }
        public ICollection<OrderProduct>? Products { get; init; }
        public DateTime CreateAt { get; init; }
    }
}
