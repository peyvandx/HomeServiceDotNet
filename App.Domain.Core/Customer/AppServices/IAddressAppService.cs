using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.AppServices
{
    public interface IAddressAppService
    {
        public Task<Customer.Entities.Address> CreateAddress(AddressDto addressDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> UpdateAddress(AddressDto addressDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> SoftDeleteAddress(int addressId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> GetAddressById(int addressId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Address>> GetAddresses(CancellationToken cancellationToken);
    }
}
