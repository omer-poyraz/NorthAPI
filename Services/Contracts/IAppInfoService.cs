using Entities.DataTransferObjects.AppInfoDto;

namespace Services.Contracts
{
    public interface IAppInfoService
    {
        Task<IEnumerable<AppInfoDto>> GetAllAppInfosAsync(bool trackChanges);
        Task<AppInfoDto> GetOneAppInfoAsync(int id, bool trackChanges);
        Task<AppInfoDto> CreateOneAppInfoAsync(AppInfoDtoForInsertion appInfoDtoForInsertion);
        Task<AppInfoDto> UpdateOneAppInfoAsync(int id, AppInfoDtoForUpdate appInfoDtoForUpdate, bool trackChanges);
        Task<AppInfoDto> DeleteOneAppInfoAsync(int id, bool trackChanges);
    }
}
