using AutoMapper;
using Entities.DataTransferObjects.FavoriteDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public FavoriteService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<FavoriteDto> CreateOneFavoriteAsync(FavoriteDtoForInsertion favoriteDtoForInsertion)
        {
            var favorite = _mapper.Map<Favorite>(favoriteDtoForInsertion);
            _manager.FavoriteRepository.CreateOneFavorite(favorite);
            await _manager.SaveAsync();
            return _mapper.Map<FavoriteDto>(favorite);
        }

        public async Task<FavoriteDto> DeleteOneFavoriteAsync(int favoriteId, bool trackChanges)
        {
            var favorite = await _manager.FavoriteRepository.GetOneFavoriteAsync(favoriteId, trackChanges);
            _manager.FavoriteRepository.DeleteOneFavorite(favorite);
            await _manager.SaveAsync();
            return _mapper.Map<FavoriteDto>(favorite);
        }

        public async Task<IEnumerable<FavoriteDto>> GetAllFavoritesAsync(int userId, bool trackChanges)
        {
            var favorites = await _manager.FavoriteRepository.GetAllFavoritesAsync(userId, trackChanges);
            return _mapper.Map<IEnumerable<FavoriteDto>>(favorites);
        }

        public async Task<FavoriteDto> GetOneFavoriteAsync(int favoriteId, bool trackChanges)
        {
            var favorite = await _manager.FavoriteRepository.GetOneFavoriteAsync(favoriteId, trackChanges);
            return _mapper.Map<FavoriteDto>(favorite);
        }
    }
}
