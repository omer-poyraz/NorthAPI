using Entities.Models;
using Entities.RequestFeature;

namespace Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<PagedList<Category>> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
        Task<Category> GetOneCategoryByIdAsync(int id, bool trackChanges);
        Category CreateOneCategory(Category category);
        Category UpdateOneCategory(Category category);
        Category DeleteOneCategory(Category category);
    }
}
