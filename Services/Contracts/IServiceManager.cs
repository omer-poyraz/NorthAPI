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
        INotificationService NotificationService { get; }
        IAddressService AddressService { get; }
        IAppInfoService AppInfoService { get; }
        IOrderService OrderService { get; }
    }
}
