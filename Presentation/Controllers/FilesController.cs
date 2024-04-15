using Entities.DataTransferObjects.FilesDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.Extensions;

namespace Presentation.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/Files")]
    public class FilesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public FilesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllFilesAsync()
        {
            var file = await _manager.FilesService.GetAllFilesAsync(false);
            return Ok(file);
        }

        [HttpGet("GetAllAdvert")]
        public async Task<IActionResult> GetAllAdvertFilesAsync()
        {
            var adverts = await _manager.FilesService.GetAllAdvertFilesAsync(false);
            return Ok(adverts);
        }

        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategoryFilesAsync()
        {
            var category = await _manager.FilesService.GetAllCategoryFilesAsync(false);
            return Ok(category);
        }

        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> GetAllProductFilesAsync()
        {
            var product = await _manager.FilesService.GetAllProductFilesAsync(false);
            return Ok(product);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetOneFilesAsync([FromRoute] int id)
        {
            var file = await _manager.FilesService.GetOneFilesByIdAsync(id, false);
            return Ok(file);
        }

        [HttpPost("Upload/{productId:int}/{fieldId:int}")]
        public async Task<IActionResult> UploadFile(IFormFile file, [FromRoute] int productId, int fieldId)
        {
            var rnd = new Random();
            var imgId = rnd.Next(0, 100000);
            var upload = await FileManager.FileUpload(file, fieldId, imgId);
            var fileDto = new FilesDtoForInsertion
            {
                ProductId = productId,
                FieldId = fieldId,
                FieldName = $"{upload["FieldName"]}",
                FilesName = $"{imgId}_{upload["FilesName"]}",
                FilesPath = $"{upload["FilesPath"]}",
                FilesFullPath = $"{upload["FilesFullPath"]}"
            };
            var result = await _manager.FilesService.CreateOneFilesAsync(fileDto);
            return Ok(result);
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> DeleteFile([FromRoute] int id)
        {
            var file = await _manager.FilesService.GetOneFilesByIdAsync(id, false);
            FileManager.FileDelete(file.FilesPath!, file.FilesName!);
            var result = await _manager.FilesService.DeleteOneFilesAsync(id, false);
            return Ok(result);
        }
    }
}