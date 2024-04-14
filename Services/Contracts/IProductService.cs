using Entities.DataTransferObjects.ProductDto;
using Entities.RequestFeature;

namespace Services.Contracts
{
    public interface IProductService
    {
        Task<(IEnumerable<ProductDto> productDtos, MetaData metaData)> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges);
        Task<ProductDto> GetOneProductAsync(int id, bool trackChanges);
        Task<ProductDto> CreateOneProductAsync(ProductDtoForInsertion productDtoForInsertion);
        Task<ProductDto> UpdateOneProductAsync(int id, ProductDtoForUpdate productDtoForUpdate, bool trackChanges);
        Task<ProductDto> DeleteOneProductAsync(int id, bool trackChanges);
    }
}
