namespace Entities.DataTransferObjects.NotificationDto
{
    public record NotificationDto
    {
        public int NotificationId { get; init; }
        public int UserId { get; init; }
        public string? NotificationTitle { get; init; }
        public string? NotificationDesc { get; init; }
        public DateTime CreateAt { get; init; }
    }
}
