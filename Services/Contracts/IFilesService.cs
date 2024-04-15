using Entities.DataTransferObjects.FilesDto;

namespace Services.Contracts
{
    public interface IFilesService
    {
        Task<IEnumerable<FilesDto>> GetAllFilesAsync(bool trackChanges);
        Task<IEnumerable<FilesDto>> GetAllAdvertFilesAsync(bool trackChanges);
        Task<IEnumerable<FilesDto>> GetAllCategoryFilesAsync(bool trackChanges);
        Task<IEnumerable<FilesDto>> GetAllProductFilesAsync(bool trackChanges);
        Task<FilesDto> GetOneFilesByIdAsync(int id, bool trackChanges);
        Task<FilesDto> CreateOneFilesAsync(FilesDtoForInsertion filesDtoForInsertion);
        Task<FilesDto> UpdateOneFilesAsync(int id, FilesDtoForUpdate filesDtoForUpdate, bool trackChanges);
        Task<FilesDto> DeleteOneFilesAsync(int id, bool trackChanges);
    }
}
