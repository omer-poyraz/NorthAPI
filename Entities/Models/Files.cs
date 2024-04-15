namespace Entities.Models
{
    public class Files
    {
        public int FilesId { get; set; }
        public int ProductId { get; set; }
        public int FieldId { get; set; }
        public string? FieldName { get; set; }
        public string? FilesName { get; set; }
        public string? FilesPath { get; set; }
        public string? FilesFullPath { get; set; }
        public DateTime CreateAt { get; set; }

        public Files()
        {
            CreateAt = DateTime.Now;
        }
    }
}
