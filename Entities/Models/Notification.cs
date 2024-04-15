namespace Entities.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string? NotificationTitle { get; set; }
        public string? NotificationDesc { get; set; }
        public DateTime CreateAt { get; set; }

        public Notification()
        {
            CreateAt = DateTime.Now;
        }
    }
}
