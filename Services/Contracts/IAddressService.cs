using Entities.DataTransferObjects.AddressDto;

namespace Services.Contracts
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressDto>> GetAllAddressAsync(int userId, bool trackChanges);
        Task<AddressDto> GetOneAddressAsync(int addressId, bool trackChanges);
        Task<AddressDto> CreateOneAddressAsync(AddressDtoForInsertion addressDtoForInsertion);
        Task<AddressDto> UpdateOneAddressAsync(int addressId, AddressDtoForUpdate addressDtoForUpdate, bool trackChanges);
        Task<AddressDto> DeleteOneAddressAsync(int addressId, bool trackChanges);
    }
}
