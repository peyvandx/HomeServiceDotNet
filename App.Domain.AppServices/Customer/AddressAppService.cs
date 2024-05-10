using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class AddressAppService : IAddressAppService
    {
        #region Fields
        private readonly IAddressService _addressService;
        #endregion

        #region Ctors
        public AddressAppService(IAddressService addressService)
        {
            _addressService = addressService;
        }
        #endregion

        #region Implementations
        public async Task<Address> CreateAddress(AddressDto addressDto, CancellationToken cancellationToken)
            => await _addressService.CreateAddress(addressDto, cancellationToken);

        public async Task<AddressDto> GetAddressById(int addressId, CancellationToken cancellationToken)
            => await _addressService.GetAddressById(addressId, cancellationToken);

        public async Task<List<AddressDto>> GetAddresses(CancellationToken cancellationToken)
            => await _addressService.GetAddresses(cancellationToken);

        //public async Task<Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken)
        //    => await _addressService.HardDeleteAddress(addressId, cancellationToken);

        public async Task<AddressSoftDeleteDto> SoftDeleteAddress(int addressId, CancellationToken cancellationToken)
            => await _addressService.SoftDeleteAddress(addressId, cancellationToken);

        public async Task<AddressDto> UpdateAddress(AddressDto addressDto, CancellationToken cancellationToken)
            => await _addressService.UpdateAddress(addressDto, cancellationToken);
        #endregion
    }
}
