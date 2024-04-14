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
        public ServiceManager(IAuthenticationService authenticationService, ICategoryService categoryService, IUserService userService, IFilesService fileService, IProductService productService, IFavoriteService favoriteService, IBasketService basketService)
        {
            _authenticationService = authenticationService;
            _categoryService = categoryService;
            _userService = userService;
            _fileService = fileService;
            _productService = productService;
            _favoriteService = favoriteService;
            _basketService = basketService;
        }

        public IAuthenticationService AuthenticationService => _authenticationService;
        public ICategoryService CategoryService => _categoryService;
        public IUserService UserService => _userService;
        public IFilesService FilesService => _fileService;
        public IProductService ProductService => _productService;
        public IFavoriteService FavoriteService => _favoriteService;
        public IBasketService BasketService => _basketService;
    }
}
