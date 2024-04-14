using Entities.DataTransferObjects.FilesDto;

namespace Services.Contracts
{
    public interface IFilesService
    {
        Task<IEnumerable<FilesDto>> GetAllFilesDto(bool trackChanges);
        Task<FilesDto> GetOneFilesByIdAsync(int id, bool trackChanges);
        Task<FilesDto> CreateOneFilesAsync(FilesDtoForInsertion filesDtoForInsertion);
        Task<FilesDto> UpdateOneFilesAsync(int id, FilesDtoForUpdate filesDtoForUpdate, bool trackChanges);
        Task<FilesDto> DeleteOneFilesAsync(int id, bool trackChanges);
    }
}
