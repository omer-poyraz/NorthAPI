using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext context) : base(context)
        {
        }

        public Address CreateOneAddress(Address address)
        {
            Create(address);
            return address;
        }

        public Address DeleteOneAddress(Address address)
        {
            Delete(address);
            return address;
        }

        public async Task<IEnumerable<Address>> GetAllAddressAsync(int userId, bool trackChanges) =>
            await FindAll(trackChanges)
            .Where(a => a.UserId.Equals(userId))
            .OrderBy(a => a.AddressId)
            .ToListAsync();

        public async Task<Address> GetOneAddressAsync(int addressId, bool trackChanges) =>
            await FindByCondition(a => a.AddressId.Equals(addressId), trackChanges).SingleOrDefaultAsync();

        public Address UpdateOneAddress(Address address)
        {
            Update(address);
            return address;
        }
    }
}
