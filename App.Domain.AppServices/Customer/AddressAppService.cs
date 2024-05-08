using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class AddressAppService : IAddressAppService
    {
        public AddressAppService() { }
        public Task<Address> CreateAddress(AddressDto addressDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Address>> GetAddresses(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Address> SoftDeleteAddress(int addressId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateAddress(AddressDto addressDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
