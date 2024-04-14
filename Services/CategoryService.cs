using AutoMapper;
using Entities.DataTransferObjects.CategoryDto;
using Entities.Models;
using Entities.RequestFeature;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ILoggerService _loggerService;
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CategoryService(ILoggerService loggerService, IRepositoryManager manager, IMapper mapper)
        {
            _loggerService = loggerService;
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<CategoryDto> CreateOneCategoryAsync(CategoryDtoForInsertion categoryDtoForInsertion)
        {
            var category = _mapper.Map<Category>(categoryDtoForInsertion);
            _manager.CategoryRepository.CreateOneCategory(category);
            await _manager.SaveAsync();
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> DeleteOneCategoryAsnyc(int id, bool trackChanges)
        {
            var category = await _manager.CategoryRepository.GetOneCategoryByIdAsync(id, trackChanges);
            _manager.CategoryRepository.DeleteOneCategory(category);
            await _manager.SaveAsync();
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<(IEnumerable<CategoryDto> categoryDtos, MetaData metaData)> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges)
        {
            var categories = await _manager.CategoryRepository.GetAllCategoriesAsync(categoryParameters, trackChanges);
            var categoryDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);
            return (categoryDto, categories.MetaData);
        }

        public async Task<CategoryDto> GetOneCategoryByIdAsync(int id, bool trackChanges)
        {
            var category = await _manager.CategoryRepository.GetOneCategoryByIdAsync(id, trackChanges);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> UpdateOneCategoryAsync(int id, CategoryDtoForUpdate categoryDtoForUpdate, bool trackChanges)
        {
            var category = _mapper.Map<Category>(categoryDtoForUpdate);
            _manager.CategoryRepository.UpdateOneCategory(category);
            await _manager.SaveAsync();
            return _mapper.Map<CategoryDto>(category);
        }
    }
}
