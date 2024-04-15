using Entities.DataTransferObjects.OrderDto;

namespace Services.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync(int userId, bool trackChanges);
        Task<OrderDto> GetOneOrderAsync(int orderId, bool trackChanges);
        Task<OrderDto> CreateOneOrderAsync(OrderDtoForInsertion orderDtoForInsertion);
        Task<OrderDto> DeleteOneOrderAsync(int orderId, bool trackChanges);
    }
}
