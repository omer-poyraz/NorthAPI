using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class FilesRepository : RepositoryBase<Files>, IFileRepository
    {
        public FilesRepository(RepositoryContext context) : base(context)
        {
        }

        public Files CreateOneFiles(Files files)
        {
            Create(files);
            return files;
        }

        public Files DeleteOneFiles(Files files)
        {
            Delete(files);
            return files;
        }

        public async Task<IEnumerable<Files>> GetAllAdvertFilesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(a => a.FieldId.Equals(1))
            .OrderBy(f => f.FilesId)
            .ToListAsync();

        public async Task<IEnumerable<Files>> GetAllCategoryFilesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(c => c.FieldId.Equals(2))
            .OrderBy(f => f.FilesId)
            .ToListAsync();

        public async Task<IEnumerable<Files>> GetAllProductFilesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(p => p.FieldId.Equals(3))
            .OrderBy(f => f.FilesId)
            .ToListAsync();


        public async Task<IEnumerable<Files>> GetAllFilesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(f => f.FilesId)
            .ToListAsync();

        public async Task<Files> GetOneFilesAsync(int id, bool trackChanges) =>
            await FindByCondition(f => f.FilesId.Equals(id), trackChanges).SingleOrDefaultAsync();

        public Files UpdateOneFiles(Files files)
        {
            Update(files);
            return files;
        }
    }
}
