using AutoMapper;
using Entities.DataTransferObjects.UserDto;
using Entities.Models;
using Entities.RequestFeature;
using Microsoft.AspNetCore.Identity;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private UserManager<User> _userManager;
        public UserService(IRepositoryManager manager, ILoggerService logger, IMapper mapper, UserManager<User> userManager)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserDto> DeleteOneUserAsync(int userId, bool trackChanges)
        {
            var user = await _manager.UserRepository.GetOneUserByIdAsync(userId, trackChanges);
            try
            {
                _manager.UserRepository.DeleteOneUser(user);
                await _manager.SaveAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }

            return _mapper.Map<UserDto>(user);
        }

        public async Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await _manager.UserRepository.GetAllUsersAsync(userParameters, trackChanges);
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return (userDto, users.MetaData);
        }

        public async Task<UserDto> GetOneUserByIdAsync(int userId, bool trackChanges)
        {
            var user = await _manager.UserRepository.GetOneUserByIdAsync(userId, trackChanges);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> UpdateOneUserAsync(int userId, UserDtoForUpdate userDtoForUpdate, bool trackChanges)
        {
            var userDto = await _manager.UserRepository.GetOneUserByIdAsync(userId, trackChanges);
            var user = await _userManager.FindByEmailAsync(userDto.Email!);

            user!.UserName = userDtoForUpdate.UserName;
            user.FirstName = userDtoForUpdate.FirstName;
            user.LastName = userDtoForUpdate.LastName;
            user.Email = userDtoForUpdate.Email;
            user.PhoneNumber = userDtoForUpdate.PhoneNumber;

            await _userManager.UpdateAsync(user);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> ChangePasswordAsync(int userId, string currentPassword, string newPassword, bool trackChanges)
        {
            var userDto = await _manager.UserRepository.GetOneUserByIdAsync(userId, trackChanges);
            var user = await _userManager.FindByEmailAsync(userDto.Email!);

            await _userManager.ChangePasswordAsync(user!, currentPassword, newPassword);
            return _mapper.Map<UserDto>(user);
        }
    }
}
