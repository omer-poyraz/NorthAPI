using AutoMapper;
using Entities.DataTransferObjects.BasketDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class BasketService : IBasketService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public BasketService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BasketDto> CreateOneBasketAsync(BasketDtoForInsertion basketDto)
        {
            var basket = _mapper.Map<Basket>(basketDto);
            _manager.BasketRepository.CreateOneBasket(basket);
            await _manager.SaveAsync();
            return _mapper.Map<BasketDto>(basket);
        }

        public async Task<BasketDto> DeleteOneBasketAsync(int basketId, bool trackChanges)
        {
            var basket = await _manager.BasketRepository.GetOneBasketAsync(basketId, trackChanges);
            _manager.BasketRepository.DeleteOneBasket(basket);
            await _manager.SaveAsync();
            return _mapper.Map<BasketDto>(basket);
        }

        public async Task<IEnumerable<BasketDto>> GetAllBasketsAsync(int userId, bool trackChanges)
        {
            var baskets = await _manager.BasketRepository.GetAllBasketsAsync(userId, trackChanges);
            return _mapper.Map<IEnumerable<BasketDto>>(baskets);
        }

        public async Task<BasketDto> GetOneBasketAsync(int basketId, bool trackChanges)
        {
            var basket = await _manager.BasketRepository.GetOneBasketAsync(basketId, trackChanges);
            return _mapper.Map<BasketDto>(basket);
        }

        public async Task<BasketDto> UpdateOneBasketAsync(int basketId, BasketDtoForUpdate basketDtoForUpdate, bool trackChanges)
        {
            var basket = await _manager.BasketRepository.GetOneBasketAsync(basketId, trackChanges);
            basket = _mapper.Map<Basket>(basketDtoForUpdate);
            _manager.BasketRepository.UpdateOneBasket(basket);
            await _manager.SaveAsync();
            return _mapper.Map<BasketDto>(basket);
        }
    }
}
