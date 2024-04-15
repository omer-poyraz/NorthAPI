namespace Entities.DataTransferObjects.AppInfoDto
{
    public record AppInfoDto
    {
        public int InfoId { get; init; }
        public int InfoContentId { get; init; }
        public string? InfoTitle { get; init; }
        public string? InfoContent { get; init; }
    }
}
