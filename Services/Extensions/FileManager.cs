using Microsoft.AspNetCore.Http;

namespace Services.Extensions
{
    public class FileManager
    {
        public static async Task<Dictionary<object, object>> FileUpload(IFormFile file, string field, int id)
        {
            var result = new Dictionary<object, object>();
            var basePath = "C:\\Users\\user\\Desktop\\NorthAPI\\Files";
            var folder = Path.Combine(basePath, "Media", field);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var path = Path.Combine(folder, $"{id}_{file.FileName}");
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            result.Add("FilesName", file.FileName);
            result.Add("FilesPath", folder);
            result.Add("FilesFullPath", Path.Combine(folder, file.FileName));
            return result;
        }

        public static void FileDelete(string path, string file)
        {
            if (File.Exists(Path.Combine(path, file)))
                File.Delete(Path.Combine(path, file));
        }
    }
}
