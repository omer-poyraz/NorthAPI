using Entities.Models;
using Entities.RequestFeature;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public Product CreateOneProduct(Product product)
        {
            Create(product);
            return product;
        }

        public Product DeleteOneProduct(Product product)
        {
            Delete(product);
            return product;
        }

        public async Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await FindAll(trackChanges)
                .SearchProduct(productParameters.SearchTerm!)
                .OrderBy(p => p.ProductId)
                .Include(c => c.Category)
                .Include(f => f.Files)
                .ToListAsync();
            return PagedList<Product>.ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<Product> GetOneProductAsync(int id, bool trackChanges) =>
            await FindByCondition(p => p.ProductId.Equals(id), trackChanges)
            .Include(c => c.Category)
            .Include(f => f.Files)
            .SingleOrDefaultAsync();

        public Product UpdateOneProduct(Product product)
        {
            Update(product);
            return product;
        }
    }
}
