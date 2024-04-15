namespace Entities.DataTransferObjects.AddressDto
{
    public record AddressDto
    {
        public int AddressId { get; init; }
        public int UserId { get; init; }
        public string? AddressTitle { get; init; }
        public string? AddressText { get; init; }
        public string? AddressCity { get; init; }
        public string? AddressDistrict { get; init; }
        public DateTime CreateAt { get; init; }
    }
}
