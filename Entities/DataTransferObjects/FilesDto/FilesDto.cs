﻿namespace Entities.DataTransferObjects.FilesDto
{
    public record FilesDto
    {
        public int FilesId { get; init; }
        public int ProductId { get; init; }
        public int FieldId { get; init; }
        public string? FieldName { get; init; }
        public string? FilesName { get; init; }
        public string? FilesPath { get; init; }
        public string? FilesFullPath { get; init; }
    }
}
