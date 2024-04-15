using Entities.Models;
using Entities.RequestFeature;

namespace Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        Task<User> GetOneUserByIdAsync(int userId, bool trackChanges);
        User UpdateOneUser(User user);
        User ChangePassword(User user);
        User DeleteOneUser(User user);
    }
}
