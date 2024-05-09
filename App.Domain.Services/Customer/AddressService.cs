using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class AddressService : IAddressService
    {
        #region Fields
        private readonly IAddressRepository _addressRepository;
        #endregion

        #region Ctors
        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        #endregion

        #region Implementations
        public async Task<Address> CreateAddress(AddressDto addressDto, CancellationToken cancellationToken)
        {
            var creatingAddress = new Address();
            creatingAddress.CreatedAt = DateTime.Now;
            creatingAddress.Street = addressDto.Street;
            creatingAddress.PostalCode = addressDto.PostalCode;
            creatingAddress.CityId = addressDto.CityId;
            creatingAddress.CustomerId = addressDto.CustomerId;
            creatingAddress.ExpertId = addressDto.ExpertId;
            return await _addressRepository.CreateAddress(creatingAddress, cancellationToken);
        }

        public async Task<AddressDto> GetAddressById(int addressId, CancellationToken cancellationToken)
            => await _addressRepository.GetAddressById(addressId, cancellationToken);

        public async Task<List<AddressDto>> GetAddresses(CancellationToken cancellationToken)
            => await _addressRepository.GetAddresses(cancellationToken);

        //public async Task<Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken)
        //    => await _addressRepository.HardDeleteAddress(addressId, cancellationToken);

        public async Task<AddressSoftDeleteDto> SoftDeleteAddress(int addressId, CancellationToken cancellationToken)
            => await _addressRepository.SoftDeleteAddress(addressId, cancellationToken);

        public async Task<AddressDto> UpdateAddress(AddressDto addressDto, CancellationToken cancellationToken)
        {
            var updatedAddress = new Address();
            updatedAddress.CreatedAt = DateTime.Now;
            updatedAddress.Street = addressDto.Street;
            updatedAddress.PostalCode = addressDto.PostalCode;
            updatedAddress.CityId = addressDto.CityId;
            return await _addressRepository.UpdateAddress(updatedAddress, cancellationToken);
        }

        #endregion

    }
}
