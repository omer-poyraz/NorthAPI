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
            var file = await _manager.FilesService.GetAllFilesDto(false);
            return Ok(file);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetOneFilesAsync([FromRoute] int id)
        {
            var file = await _manager.FilesService.GetOneFilesByIdAsync(id, false);
            return Ok(file);
        }

        [HttpPost("Upload/{productId:int}")]
        public async Task<IActionResult> UploadFile(IFormFile file, [FromRoute] int productId)
        {
            var rnd = new Random();
            var imgId = rnd.Next(0, 100000);
            var upload = await FileManager.FileUpload(file, "Product", imgId);
            var fileDto = new FilesDtoForInsertion
            {
                ProductId = productId,
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