using Repositories.Contracts;

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
        public RepositoryManager(RepositoryContext context, ICategoryRepository categoryRepository, IUserRepository userRepository, IFileRepository fileRepository, IProductRepository productRepository, IFavoriteRepository favoriteRepository, IBasketRepository basketRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            _fileRepository = fileRepository;
            _productRepository = productRepository;
            _favoriteRepository = favoriteRepository;
            _basketRepository = basketRepository;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository;
        public IUserRepository UserRepository => _userRepository;
        public IFileRepository FileRepository => _fileRepository;
        public IProductRepository ProductRepository => _productRepository;
        public IFavoriteRepository FavoriteRepository => _favoriteRepository;
        public IBasketRepository BasketRepository => _basketRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
