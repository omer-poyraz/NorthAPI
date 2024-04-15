using AutoMapper;
using Entities.DataTransferObjects.AddressDto;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class AddressService : IAddressService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public AddressService(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<AddressDto> CreateOneAddressAsync(AddressDtoForInsertion addressDtoForInsertion)
        {
            var address = _mapper.Map<Address>(addressDtoForInsertion);
            _manager.AddressRepository.CreateOneAddress(address);
            await _manager.SaveAsync();
            return _mapper.Map<AddressDto>(address);
        }

        public async Task<AddressDto> DeleteOneAddressAsync(int addressId, bool trackChanges)
        {
            var address = await _manager.AddressRepository.GetOneAddressAsync(addressId, trackChanges);
            _manager.AddressRepository.DeleteOneAddress(address);
            await _manager.SaveAsync();
            return _mapper.Map<AddressDto>(address);
        }

        public async Task<IEnumerable<AddressDto>> GetAllAddressAsync(int userId, bool trackChanges)
        {
            var address = await _manager.AddressRepository.GetAllAddressAsync(userId, trackChanges);
            return _mapper.Map<IEnumerable<AddressDto>>(address);
        }

        public async Task<AddressDto> GetOneAddressAsync(int addressId, bool trackChanges)
        {
            var address = await _manager.AddressRepository.GetOneAddressAsync(addressId, trackChanges);
            return _mapper.Map<AddressDto>(address);
        }

        public async Task<AddressDto> UpdateOneAddressAsync(int addressId, AddressDtoForUpdate addressDtoForUpdate, bool trackChanges)
        {
            var address = await _manager.AddressRepository.GetOneAddressAsync(addressId, trackChanges);
            address = _mapper.Map<Address>(addressDtoForUpdate);
            _manager.AddressRepository.UpdateOneAddress(address);
            await _manager.SaveAsync();
            return _mapper.Map<AddressDto>(address);
        }
    }
}
