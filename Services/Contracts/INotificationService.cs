using Entities.DataTransferObjects.NotificationDto;

namespace Services.Contracts
{
    public interface INotificationService
    {
        Task<IEnumerable<NotificationDto>> GetAllNotificationsAsync(int userId, bool trackChanges);
        Task<NotificationDto> GetOneNotificationAsync(int notificationId, bool trackChanges);
        Task<NotificationDto> CreateOneNotificationAsync(NotificationDtoForInsertion notificationDtoForInsertion);
        Task<NotificationDto> DeleteOneNotificationAsync(int notificationId, bool trackChanges);
    }
}
