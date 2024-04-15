using Entities.DataTransferObjects.UserDto;
using Entities.RequestFeature;

namespace Services.Contracts
{
    public interface IUserService
    {
        Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        Task<UserDto> GetOneUserByIdAsync(int userId, bool trackChanges);
        Task<UserDto> UpdateOneUserAsync(int userId, UserDtoForUpdate userDtoForUpdate, bool trackChanges);
        Task<UserDto> ChangePasswordAsync(int userId, string currentPassword, string newPassword, bool trackChanges);
        Task<UserDto> DeleteOneUserAsync(int userId, bool trackChanges);
    }
}
