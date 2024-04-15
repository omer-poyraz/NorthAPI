using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class BasketRepository : RepositoryBase<Basket>, IBasketRepository
    {
        public BasketRepository(RepositoryContext context) : base(context)
        {
        }

        public Basket CreateOneBasket(Basket basket)
        {
            Create(basket);
            return basket;
        }

        public Basket DeleteOneBasket(Basket basket)
        {
            Delete(basket);
            return basket;
        }

        public async Task<IEnumerable<Basket>> GetAllBasketsAsync(int userId, bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(b=>b.UserId.Equals(userId))
            .OrderBy(b => b.BasketId)
            .Include(p => p.Product)
            .ToListAsync();

        public async Task<Basket> GetOneBasketAsync(int basketId, bool trackChanges) =>
            await FindByCondition(b => b.BasketId.Equals(basketId), trackChanges)
            .Include(p => p.Product)
            .SingleOrDefaultAsync();

        public Basket UpdateOneBasket(Basket basket)
        {
            Update(basket);
            return basket;
        }
    }
}
