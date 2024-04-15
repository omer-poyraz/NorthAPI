using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {
        }

        public Order CreateOneOrder(Order order)
        {
            Create(order);
            return order;
        }

        public Order DeleteOneOrder(Order order)
        {
            Delete(order);
            return order;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync(int userId, bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(o => o.UserId.Equals(userId))
            .OrderBy(o => o.OrderId)
            .ToListAsync();

        public async Task<Order> GetOneOrderAsync(int orderId, bool trackChanges) =>
            await FindByCondition(o => o.OrderId.Equals(orderId), trackChanges).SingleOrDefaultAsync();
    }
}
