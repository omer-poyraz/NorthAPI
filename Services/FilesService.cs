﻿using AutoMapper;
using Entities.DataTransferObjects.FilesDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class FilesService : IFilesService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public FilesService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<FilesDto> CreateOneFilesAsync(FilesDtoForInsertion filesDtoForInsertion)
        {
            var files = _mapper.Map<Files>(filesDtoForInsertion);
            _manager.FileRepository.CreateOneFiles(files);
            await _manager.SaveAsync();
            return _mapper.Map<FilesDto>(files);
        }

        public async Task<FilesDto> DeleteOneFilesAsync(int id, bool trackChanges)
        {
            var file = await _manager.FileRepository.GetOneFilesAsync(id, trackChanges);
            _manager.FileRepository.DeleteOneFiles(file);
            await _manager.SaveAsync();
            return _mapper.Map<FilesDto>(file);
        }

        public async Task<IEnumerable<FilesDto>> GetAllAdvertFilesAsync(bool trackChanges)
        {
            var advert = await _manager.FileRepository.GetAllAdvertFilesAsync(trackChanges);
            return _mapper.Map<IEnumerable<FilesDto>>(advert);
        }

        public async Task<IEnumerable<FilesDto>> GetAllCategoryFilesAsync(bool trackChanges)
        {
            var category = await _manager.FileRepository.GetAllCategoryFilesAsync(trackChanges);
            return _mapper.Map<IEnumerable<FilesDto>>(category);
        }

        public async Task<IEnumerable<FilesDto>> GetAllFilesAsync(bool trackChanges)
        {
            var files = await _manager.FileRepository.GetAllFilesAsync(trackChanges);
            return _mapper.Map<IEnumerable<FilesDto>>(files);
        }

        public async Task<IEnumerable<FilesDto>> GetAllProductFilesAsync(bool trackChanges)
        {
            var product = await _manager.FileRepository.GetAllProductFilesAsync(trackChanges);
            return _mapper.Map<IEnumerable<FilesDto>>(product);
        }

        public async Task<FilesDto> GetOneFilesByIdAsync(int id, bool trackChanges)
        {
            var file = await _manager.FileRepository.GetOneFilesAsync(id, trackChanges);
            return _mapper.Map<FilesDto>(file);
        }

        public async Task<FilesDto> UpdateOneFilesAsync(int id, FilesDtoForUpdate filesDtoForUpdate, bool trackChanges)
        {
            var file = await _manager.FileRepository.GetOneFilesAsync(id, trackChanges);
            file = _mapper.Map<Files>(filesDtoForUpdate);
            _manager.FileRepository.UpdateOneFiles(file);
            await _manager.SaveAsync();
            return _mapper.Map<FilesDto>(file);
        }
    }
}
