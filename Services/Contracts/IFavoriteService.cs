using Entities.DataTransferObjects.FavoriteDto;

namespace Services.Contracts
{
    public interface IFavoriteService
    {
        Task<IEnumerable<FavoriteDto>> GetAllFavoritesAsync(int userId, bool trackChanges);
        Task<FavoriteDto> GetOneFavoriteAsync(int favoriteId, bool trackChanges);
        Task<FavoriteDto> CreateOneFavoriteAsync(FavoriteDtoForInsertion favoriteDtoForInsertion);
        Task<FavoriteDto> DeleteOneFavoriteAsync(int favoriteId, bool trackChanges);
    }
}
