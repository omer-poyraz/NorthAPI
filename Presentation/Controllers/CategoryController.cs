using Entities.DataTransferObjects.CategoryDto;
using Entities.RequestFeature;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Text.Json;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Category")]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCategoriesAsync([FromQuery] CategoryParameters categoryParameters)
        {
            var categories = await _manager.CategoryService.GetAllCategoriesAsync(categoryParameters, false);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(categories.metaData));
            return Ok(categories);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetOneCategoryByIdAsync([FromRoute] int id)
        {
            var category = await _manager.CategoryService.GetOneCategoryByIdAsync(id, false);
            return Ok(category);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateOneCategoryAsync([FromBody] CategoryDtoForInsertion categoryDtoForInsertion)
        {
            var category = await _manager.CategoryService.CreateOneCategoryAsync(categoryDtoForInsertion);
            return Ok(category);
        }

        [HttpPut("Update/{id:int}")]
        public async Task<IActionResult> UpdateOneCategoryAsync([FromRoute] int id, [FromBody] CategoryDtoForUpdate categoryDtoForUpdate)
        {
            var category = await _manager.CategoryService.UpdateOneCategoryAsync(id, categoryDtoForUpdate, false);
            return Ok(category);
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> DeleteOneCategoryAsync([FromRoute] int id)
        {
            var category = await _manager.CategoryService.DeleteOneCategoryAsnyc(id, false);
            return Ok(category);
        }
    }
}
