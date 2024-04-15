namespace Entities.Models
{

    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public decimal OrderPrice { get; set; }
        public User? User { get; set; }
        public Address? Address { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
        public DateTime? CreateAt { get; set; }

        public Order()
        {
            CreateAt = DateTime.Now;
        }
    }
}
