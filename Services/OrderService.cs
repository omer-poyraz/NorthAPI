using AutoMapper;
using Entities.DataTransferObjects.OrderDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public OrderService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<OrderDto> CreateOneOrderAsync(OrderDtoForInsertion orderDtoForInsertion)
        {
            var order = _mapper.Map<Order>(orderDtoForInsertion);
            _manager.OrderRepository.CreateOneOrder(order);
            await _manager.SaveAsync();
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<OrderDto> DeleteOneOrderAsync(int orderId, bool trackChanges)
        {
            var order = await _manager.OrderRepository.GetOneOrderAsync(orderId, trackChanges);
            _manager.OrderRepository.DeleteOneOrder(order);
            await _manager.SaveAsync();
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync(int userId, bool trackChanges)
        {
            var orders = await _manager.OrderRepository.GetAllOrdersAsync(userId, trackChanges);
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public async Task<OrderDto> GetOneOrderAsync(int orderId, bool trackChanges)
        {
            var order = await _manager.OrderRepository.GetOneOrderAsync(orderId, trackChanges);
            return _mapper.Map<OrderDto>(order);
        }
    }
}
