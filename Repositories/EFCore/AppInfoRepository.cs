using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class AppInfoRepository : RepositoryBase<AppInfo>, IAppInfoRepository
    {
        public AppInfoRepository(RepositoryContext context) : base(context)
        {
        }

        public AppInfo CreateOneAppInfo(AppInfo appInfo)
        {
            Create(appInfo);
            return appInfo;
        }

        public AppInfo DeleteOneAppInfo(AppInfo appInfo)
        {
            Delete(appInfo);
            return appInfo;
        }

        public async Task<IEnumerable<AppInfo>> GetAllAppInfosAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(a => a.InfoId)
            .ToListAsync();

        public async Task<AppInfo> GetOneAppInfoAsync(int id, bool trackChanges) =>
            await FindByCondition(a => a.InfoId.Equals(id), trackChanges).SingleOrDefaultAsync();

        public AppInfo UpdateOneAppInfo(AppInfo appInfo)
        {
            Update(appInfo);
            return appInfo;
        }
    }
}
