using Entities.Models;
using Entities.RequestFeature;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges);
        Task<Product> GetOneProductAsync(int id, bool trackChanges);
        Product CreateOneProduct(Product product);
        Product UpdateOneProduct(Product product);
        Product DeleteOneProduct(Product product);
    }
}
