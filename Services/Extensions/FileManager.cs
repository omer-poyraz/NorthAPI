using Microsoft.AspNetCore.Http;

namespace Services.Extensions
{
    public class FileManager
    {
        private static List<string> Fields = ["Advert", "Category", "Product"];
        public static async Task<Dictionary<string, object>> FileUpload(IFormFile file, int fieldId, int id)
        {
            var result = new Dictionary<string, object>();
            var basePath = "C:\\Users\\user\\Desktop\\NorthAPI\\Files";
            var folder = Path.Combine(basePath, "Media", Fields[fieldId - 1]);

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
            result.Add("FieldId", fieldId);
            result.Add("FieldName", Fields[fieldId - 1]);
            return result;
        }

        public static void FileDelete(string path, string file)
        {
            if (File.Exists(Path.Combine(path, file)))
                File.Delete(Path.Combine(path, file));
        }
    }
}
