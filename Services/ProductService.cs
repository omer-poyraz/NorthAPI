using AutoMapper;
using Entities.DataTransferObjects.ProductDto;
using Entities.Models;
using Entities.RequestFeature;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateOneProductAsync(ProductDtoForInsertion productDtoForInsertion)
        {
            var product = _mapper.Map<Product>(productDtoForInsertion);
            _manager.ProductRepository.CreateOneProduct(product);
            await _manager.SaveAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> DeleteOneProductAsync(int id, bool trackChanges)
        {
            var product = await _manager.ProductRepository.GetOneProductAsync(id, trackChanges);
            _manager.ProductRepository.DeleteOneProduct(product);
            await _manager.SaveAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<(IEnumerable<ProductDto> productDtos, MetaData metaData)> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await _manager.ProductRepository.GetAllProductsAsync(productParameters, trackChanges);
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            return (productsDto, products.MetaData);
        }

        public async Task<ProductDto> GetOneProductAsync(int id, bool trackChanges)
        {
            var product = await _manager.ProductRepository.GetOneProductAsync(id, false);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> UpdateOneProductAsync(int id, ProductDtoForUpdate productDtoForUpdate, bool trackChanges)
        {
            var product = await _manager.ProductRepository.GetOneProductAsync(id, trackChanges);
            product = _mapper.Map<Product>(productDtoForUpdate);
            _manager.ProductRepository.UpdateOneProduct(product);
            await _manager.SaveAsync();
            return _mapper.Map<ProductDto>(product);
        }
    }
}
