namespace Entities.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string? AddressTitle { get; set; }
        public string? AddressText { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressDistrict { get; set; }
        public DateTime CreateAt { get; set; }

        public Address()
        {
            CreateAt = DateTime.Now;
        }
    }
}
