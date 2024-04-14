using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.FilesDto
{
    public abstract record FilesDtoForManipulation
    {
        [Required]
        public int ProductId { get; init; }
        [Required]
        [MaxLength(100)]
        public string? FilesName { get; init; }
        [Required]
        public string? FilesPath { get; init; }
        [Required]
        public string? FilesFullPath { get; set; }
    }
}
