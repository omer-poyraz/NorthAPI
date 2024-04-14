using Entities.Models;

namespace Repositories.Contracts
{
    public interface IBasketRepository : IRepositoryBase<Basket>
    {
        Task<IEnumerable<Basket>> GetAllBasketsAsync(int userId, bool trackChanges);
        Task<Basket> GetOneBasketAsync(int basketId, bool trackChanges);
        Basket CreateOneBasket(Basket basket);
        Basket UpdateOneBasket(Basket basket);
        Basket DeleteOneBasket(Basket basket);
    }
}
