using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class FavoriteRepository : RepositoryBase<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(RepositoryContext context) : base(context)
        {
        }

        public Favorite CreateOneFavorite(Favorite favorite)
        {
            Create(favorite);
            return favorite;
        }

        public Favorite DeleteOneFavorite(Favorite favorite)
        {
            Delete(favorite);
            return favorite;
        }

        public async Task<IEnumerable<Favorite>> GetAllFavoritesAsync(int userId, bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(f=>f.UserId.Equals(userId))
            .OrderBy(f => f.FavoriteId)
            .Include(p => p.Product)
            .ToListAsync();

        public async Task<Favorite> GetOneFavoriteAsync(int favoriteId, bool trackChanges) =>
            await FindByCondition(f => f.FavoriteId.Equals(favoriteId), trackChanges)
            .Include(p => p.Product)
            .SingleOrDefaultAsync();
    }
}
