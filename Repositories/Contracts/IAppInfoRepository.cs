using Entities.Models;

namespace Repositories.Contracts
{
    public interface IAppInfoRepository : IRepositoryBase<AppInfo>
    {
        Task<IEnumerable<AppInfo>> GetAllAppInfosAsync(bool trackChanges);
        Task<AppInfo> GetOneAppInfoAsync(int id, bool trackChanges);
        AppInfo CreateOneAppInfo(AppInfo appInfo);
        AppInfo UpdateOneAppInfo(AppInfo appInfo);
        AppInfo DeleteOneAppInfo(AppInfo appInfo);
    }
}
