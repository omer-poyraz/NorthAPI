using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync(int userId, bool trackChanges);
        Task<Order> GetOneOrderAsync(int orderId, bool trackChanges);
        Order CreateOneOrder(Order order);
        Order DeleteOneOrder(Order order);
    }
}
