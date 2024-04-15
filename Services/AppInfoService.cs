using AutoMapper;
using Entities.DataTransferObjects.AppInfoDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class AppInfoService : IAppInfoService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public AppInfoService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<AppInfoDto> CreateOneAppInfoAsync(AppInfoDtoForInsertion appInfoDtoForInsertion)
        {
            var appInfo = _mapper.Map<AppInfo>(appInfoDtoForInsertion);
            _manager.AppInfoRepository.CreateOneAppInfo(appInfo);
            await _manager.SaveAsync();
            return _mapper.Map<AppInfoDto>(appInfo);
        }

        public async Task<AppInfoDto> DeleteOneAppInfoAsync(int id, bool trackChanges)
        {
            var appInfo = await _manager.AppInfoRepository.GetOneAppInfoAsync(id, trackChanges);
            return _mapper.Map<AppInfoDto>(appInfo);
        }

        public async Task<IEnumerable<AppInfoDto>> GetAllAppInfosAsync(bool trackChanges)
        {
            var appInfos = await _manager.AppInfoRepository.GetAllAppInfosAsync(trackChanges);
            return _mapper.Map<IEnumerable<AppInfoDto>>(appInfos);
        }

        public async Task<AppInfoDto> GetOneAppInfoAsync(int id, bool trackChanges)
        {
            var appInfo = await _manager.AppInfoRepository.GetOneAppInfoAsync(id, trackChanges);
            return _mapper.Map<AppInfoDto>(appInfo);
        }

        public async Task<AppInfoDto> UpdateOneAppInfoAsync(int id, AppInfoDtoForUpdate appInfoDtoForUpdate, bool trackChanges)
        {
            var appInfo = await _manager.AppInfoRepository.GetOneAppInfoAsync(id, trackChanges);
            appInfo = _mapper.Map<AppInfo>(appInfoDtoForUpdate);
            _manager.AppInfoRepository.UpdateOneAppInfo(appInfo);
            await _manager.SaveAsync();
            return _mapper.Map<AppInfoDto>(appInfo);
        }
    }
}
