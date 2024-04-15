using Entities.Models;
using Entities.RequestFeature;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public User ChangePassword(User user)
        {
            Update(user);
            return user;
        }

        public User DeleteOneUser(User user)
        {
            Delete(user);
            return user;
        }

        public async Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await FindAll(trackChanges).OrderBy(u => u.UserId).Include(r => r.Roles).SearchUser(userParameters.SearchTerm!).ToListAsync();
            return PagedList<User>.ToPagedList(users, userParameters.PageNumber, userParameters.PageSize);
        }

        public async Task<User> GetOneUserByIdAsync(int userId, bool trackChanges) =>
            await FindByCondition(u => u.UserId.Equals(userId), trackChanges).Include(r=>r.Roles).SingleOrDefaultAsync();


        public User UpdateOneUser(User user)
        {
            Update(user);
            return user;
        }
    }
}
