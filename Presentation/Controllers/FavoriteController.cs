using Entities.DataTransferObjects.FavoriteDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Favorite")]
    public class FavoriteController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public FavoriteController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll/{userId:int}")]
        public async Task<IActionResult> GetAllFavoritesAsync([FromRoute] int userId)
        {
            var favorite = await _manager.FavoriteService.GetAllFavoritesAsync(userId, false);
            return Ok(favorite);
        }

        [HttpGet("Get/{favoriteId:int}")]
        public async Task<IActionResult> GetOneFavoriteAsync([FromRoute] int favoriteId)
        {
            var favorite = await _manager.FavoriteService.GetOneFavoriteAsync(favoriteId, false);
            return Ok(favorite);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneFavoriteAsync([FromBody] FavoriteDtoForInsertion favoriteDtoForInsertion)
        {
            var favorite = await _manager.FavoriteService.CreateOneFavoriteAsync(favoriteDtoForInsertion);
            return Ok(favorite);
        }

        [HttpDelete("Delete/{favoriteId:int}")]
        public async Task<IActionResult> DeleteOneFavoriteAsync([FromRoute]int favoriteId)
        {
            var favorite = await _manager.FavoriteService.DeleteOneFavoriteAsync(favoriteId, false);
            return Ok(favorite);
        }
    }
}
