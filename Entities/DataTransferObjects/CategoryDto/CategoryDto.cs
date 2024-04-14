namespace Entities.DataTransferObjects.CategoryDto
{
    public record CategoryDto
    {
        public int CategoryId { get; init; }
        public string? CategoryName { get; init; }
        public string? CategoryImg { get; init; }
    }
}
