using Entities.Models;

namespace Repositories.Contracts
{
    public interface IFavoriteRepository : IRepositoryBase<Favorite>
    {
        Task<IEnumerable<Favorite>> GetAllFavoritesAsync(int userId, bool trackChanges);
        Task<Favorite> GetOneFavoriteAsync(int favoriteId, bool trackChanges);
        Favorite CreateOneFavorite(Favorite favorite);
        Favorite DeleteOneFavorite(Favorite favorite);
    }
}
