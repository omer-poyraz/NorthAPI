using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(RepositoryContext context) : base(context)
        {
        }

        public Notification CreateOneNotification(Notification notification)
        {
            Create(notification);
            return notification;
        }

        public Notification DeleteOneNotification(Notification notification)
        {
            Delete(notification);
            return notification;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync(int userId, bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(n => n.NotificationId)
            .Where(n => n.UserId.Equals(userId))
            .ToListAsync();

        public async Task<Notification> GetOneNotificationAsync(int notificationId, bool trackChanges) =>
            await FindByCondition(f => f.NotificationId.Equals(notificationId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
