using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class AddressRepository : IAddressRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public AddressRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Address> CreateAddress(Address submittedAddress, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Addresses.AddAsync(submittedAddress, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedAddress;
        }

        public async Task<Address> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            var address = await _homeServiceDbContext.Addresses.FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);
            if (address != null)
            {
                return address;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Address>> GetAddresses(CancellationToken cancellationToken) => await _homeServiceDbContext.Addresses.ToListAsync(cancellationToken);
        //{
        //if (addresses != null)
        //{
        //    return addresses;
        //}
        //else
        //{
        //    //throw an exception - will be implement!
        //    throw new InvalidOperationException();
        //}
        //}

        public async Task<Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken)
        {
            var deletedAddress = await GetAddress(addressId, cancellationToken);
            if (deletedAddress != null)
            {
                deletedAddress.IsDeleted = true;
                _homeServiceDbContext.Addresses.Remove(deletedAddress);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Address> SoftDeleteAddress(int addressId, CancellationToken cancellationToken)
        {
            var deletedAddress = await GetAddress(addressId, cancellationToken);
            if (deletedAddress != null)
            {
                deletedAddress.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Address> UpdateAddress(Address updatedAddress, CancellationToken cancellationToken)
        {
            var updatingAddress = await GetAddress(updatedAddress.Id, cancellationToken);
            if (updatingAddress != null)
            {
                updatingAddress.Street = updatedAddress.Street;
                updatingAddress.PostalCode = updatedAddress.PostalCode;
                updatingAddress.CityId = updatedAddress.CityId;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.Address> GetAddress(int addressId, CancellationToken cancellationToken)
        {
            var address = await _homeServiceDbContext.Addresses
                .FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);

            if (address != null)
            {
                return address;
            }

            throw new Exception($"address with id {addressId} not found");
        }
        #endregion
    }
}
