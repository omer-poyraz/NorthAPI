namespace Services.Contracts
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
        IUserService UserService { get; }
        ICategoryService CategoryService { get; }
        IFilesService FilesService { get; }
        IProductService ProductService { get; }
        IFavoriteService FavoriteService { get; }
        IBasketService BasketService { get; }
    }
}
