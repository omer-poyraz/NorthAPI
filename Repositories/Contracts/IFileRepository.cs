using Entities.Models;

namespace Repositories.Contracts
{
    public interface IFileRepository : IRepositoryBase<Files>
    {
        Task<IEnumerable<Files>> GetAllFilesAsync(bool trackChanges);
        Task<Files> GetOneFilesAsync(int id, bool trackChanges);
        Files CreateOneFiles(Files files);
        Files UpdateOneFiles(Files files);
        Files DeleteOneFiles(Files files);
    }
}
