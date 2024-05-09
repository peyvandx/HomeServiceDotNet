using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface IAddressRepository
    {
        public Task<Customer.Entities.Address> CreateAddress(Customer.Entities.Address submittedAddress, CancellationToken cancellationToken);
        public Task<AddressDto> UpdateAddress(Customer.Entities.Address updatedAddress, CancellationToken cancellationToken);
        public Task<AddressSoftDeleteDto> SoftDeleteAddress(int addressId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken);
        public Task<AddressDto> GetAddressById(int addressId, CancellationToken cancellationToken);
        public Task<List<AddressDto>> GetAddresses(CancellationToken cancellationToken);
    }
}
