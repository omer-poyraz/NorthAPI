using Entities.DataTransferObjects.BasketDto;

namespace Services.Contracts
{
    public interface IBasketService
    {
        Task<IEnumerable<BasketDto>> GetAllBasketsAsync(int userId, bool trackChanges);
        Task<BasketDto> GetOneBasketAsync(int basketId, bool trackChanges);
        Task<BasketDto> CreateOneBasketAsync(BasketDtoForInsertion basketDto);
        Task<BasketDto> UpdateOneBasketAsync(int basketId, BasketDtoForUpdate basketDtoForUpdate, bool trackChanges);
        Task<BasketDto> DeleteOneBasketAsync(int basketId, bool trackChanges);
    }
}
