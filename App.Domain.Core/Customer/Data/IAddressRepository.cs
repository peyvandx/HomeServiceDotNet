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
        public Task<Customer.Entities.Address> UpdateAddress(Customer.Entities.Address updatedAddress, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> SoftDeleteAddress(int addressId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Address> GetAddressById(int addressId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Address>> GetAddresses(CancellationToken cancellationToken);
    }
}
