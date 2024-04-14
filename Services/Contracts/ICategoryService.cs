using Entities.DataTransferObjects.CategoryDto;
using Entities.RequestFeature;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<(IEnumerable<CategoryDto> categoryDtos, MetaData metaData)> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
        Task<CategoryDto> GetOneCategoryByIdAsync(int id, bool trackChanges);
        Task<CategoryDto> CreateOneCategoryAsync(CategoryDtoForInsertion categoryDtoForInsertion);
        Task<CategoryDto> UpdateOneCategoryAsync(int id, CategoryDtoForUpdate categoryDtoForUpdate, bool trackChanges);
        Task<CategoryDto> DeleteOneCategoryAsnyc(int id, bool trackChanges);
    }
}
