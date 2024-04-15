using Entities.Models;
using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private ICategoryRepository _categoryRepository;
        private IUserRepository _userRepository;
        private IFileRepository _fileRepository;
        private IProductRepository _productRepository;
        private IFavoriteRepository _favoriteRepository;
        private IBasketRepository _basketRepository;
        private INotificationRepository _notificationRepository;
        private IAddressRepository _addressRepository;
        private IAppInfoRepository _appInfoRepository;
        private IOrderRepository _orderRepository;
        public RepositoryManager(RepositoryContext context, ICategoryRepository categoryRepository, IUserRepository userRepository, IFileRepository fileRepository, IProductRepository productRepository, IFavoriteRepository favoriteRepository, IBasketRepository basketRepository, INotificationRepository notificationRepository, IAddressRepository addressRepository, IAppInfoRepository appInfoRepository, IOrderRepository orderRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            _fileRepository = fileRepository;
            _productRepository = productRepository;
            _favoriteRepository = favoriteRepository;
            _basketRepository = basketRepository;
            _notificationRepository = notificationRepository;
            _addressRepository = addressRepository;
            _appInfoRepository = appInfoRepository;
            _orderRepository = orderRepository;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository;
        public IUserRepository UserRepository => _userRepository;
        public IFileRepository FileRepository => _fileRepository;
        public IProductRepository ProductRepository => _productRepository;
        public IFavoriteRepository FavoriteRepository => _favoriteRepository;
        public IBasketRepository BasketRepository => _basketRepository;
        public INotificationRepository NotificationRepository => _notificationRepository;
        public IAddressRepository AddressRepository => _addressRepository;
        public IAppInfoRepository AppInfoRepository => _appInfoRepository;
        public IOrderRepository OrderRepository => _orderRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
