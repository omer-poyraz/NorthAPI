namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        IFileRepository FileRepository { get; }
        IProductRepository ProductRepository { get; }
        IFavoriteRepository FavoriteRepository { get; }
        IBasketRepository BasketRepository { get; }
        Task SaveAsync();
    }
}
