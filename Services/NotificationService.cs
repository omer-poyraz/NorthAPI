using AutoMapper;
using Entities.DataTransferObjects.NotificationDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class NotificationService : INotificationService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public NotificationService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<NotificationDto> CreateOneNotificationAsync(NotificationDtoForInsertion notificationDtoForInsertion)
        {
            var notification = _mapper.Map<Notification>(notificationDtoForInsertion);
            _manager.NotificationRepository.CreateOneNotification(notification);
            await _manager.SaveAsync();
            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task<NotificationDto> DeleteOneNotificationAsync(int notificationId, bool trackChanges)
        {
            var notification = await _manager.NotificationRepository.GetOneNotificationAsync(notificationId, trackChanges);
            _manager.NotificationRepository.DeleteOneNotification(notification);
            await _manager.SaveAsync();
            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task<IEnumerable<NotificationDto>> GetAllNotificationsAsync(int userId, bool trackChanges)
        {
            var notifications = await _manager.NotificationRepository.GetAllNotificationsAsync(userId, trackChanges);
            return _mapper.Map<IEnumerable<NotificationDto>>(notifications);
        }

        public async Task<NotificationDto> GetOneNotificationAsync(int notificationId, bool trackChanges)
        {
            var notification = await _manager.NotificationRepository.GetOneNotificationAsync(notificationId, trackChanges);
            return _mapper.Map<NotificationDto>(notification);
        }
    }
}
