using Entities.Models;

namespace Repositories.Contracts
{
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
        Task<IEnumerable<Notification>> GetAllNotificationsAsync(int userId, bool trackChanges);
        Task<Notification> GetOneNotificationAsync(int notificationId, bool trackChanges);
        Notification CreateOneNotification(Notification notification);
        Notification DeleteOneNotification(Notification notification);
    }
}
