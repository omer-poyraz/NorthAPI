using Entities.Models;

namespace Repositories.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Task<IEnumerable<Address>> GetAllAddressAsync(int userId, bool trackChanges);
        Task<Address> GetOneAddressAsync(int addressId, bool trackChanges);
        Address CreateOneAddress(Address address);
        Address UpdateOneAddress(Address address);
        Address DeleteOneAddress(Address address);
    }
}
