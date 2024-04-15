using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IFilesService _fileService;
        private readonly IProductService _productService;
        private readonly IFavoriteService _favoriteService;
        private readonly IBasketService _basketService;
        private readonly INotificationService _notificationService;
        private readonly IAddressService _addressService;
        private readonly IAppInfoService _appInfoService;
        private readonly IOrderService _orderService;
        public ServiceManager(IAuthenticationService authenticationService, ICategoryService categoryService, IUserService userService, IFilesService fileService, IProductService productService, IFavoriteService favoriteService, IBasketService basketService, INotificationService notificationService, IAddressService addressService, IAppInfoService appInfoService, IOrderService orderService)
        {
            _authenticationService = authenticationService;
            _categoryService = categoryService;
            _userService = userService;
            _fileService = fileService;
            _productService = productService;
            _favoriteService = favoriteService;
            _basketService = basketService;
            _notificationService = notificationService;
            _addressService = addressService;
            _appInfoService = appInfoService;
            _orderService = orderService;
        }

        public IAuthenticationService AuthenticationService => _authenticationService;
        public ICategoryService CategoryService => _categoryService;
        public IUserService UserService => _userService;
        public IFilesService FilesService => _fileService;
        public IProductService ProductService => _productService;
        public IFavoriteService FavoriteService => _favoriteService;
        public IBasketService BasketService => _basketService;
        public INotificationService NotificationService => _notificationService;
        public IAddressService AddressService => _addressService;
        public IAppInfoService AppInfoService => _appInfoService;
        public IOrderService OrderService => _orderService;
    }
}
