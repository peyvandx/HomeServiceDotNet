using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
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
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<AddressRepository> _logger;
        #endregion

        #region Ctors
        public AddressRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<AddressRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Address> CreateAddress(Address submittedAddress, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Addresses.AddAsync(submittedAddress, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Address has been successfully added to the database.");
            return submittedAddress;
        }

        public async Task<AddressDto> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            var address = _memoryCache.Get<AddressDto?>("addressDto");
            if (address is null)
            {
                address = await _homeServiceDbContext.Addresses
                .Select(a => new Domain.Core.Customer.DTOs.AddressDto
                {
                    Id = a.Id,
                    Street = a.Street,
                    PostalCode = a.PostalCode,
                    CustomerFirstName = a.Customer.FirstName,
                    CustomerLastName = a.Customer.LastName,
                    ExpertFirstName = a.Expert.FirstName,
                    ExpertLastName = a.Expert.LastName,
                    IsDeleted = a.IsDeleted,
                    CreatedAt = a.CreatedAt
                }).FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);

                if (address != null)
                {
                    _memoryCache.Set("addressDto", address, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("addressDto returned from database, and cached in memory successfully.");
                    return address;
                }
                else
                {
                    _logger.LogError("We expected the addressDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("addressDto returned from InMemoryCache.");
            return address;
        }

        public async Task<List<AddressDto>> GetAddresses(CancellationToken cancellationToken)
        {
            var addresses = _memoryCache.Get<List<AddressDto>>("addressDtos");
            if (addresses is null)
            {
                addresses = await _homeServiceDbContext.Addresses
                .Select(a => new Domain.Core.Customer.DTOs.AddressDto
                {
                    Id = a.Id,
                    Street = a.Street,
                    PostalCode = a.PostalCode,
                    CustomerFirstName = a.Customer.FirstName,
                    CustomerLastName = a.Customer.LastName,
                    ExpertFirstName = a.Expert.FirstName,
                    ExpertLastName = a.Expert.LastName,
                    IsDeleted = a.IsDeleted,
                    CreatedAt = a.CreatedAt
                }).ToListAsync(cancellationToken);

                if (addresses != null)
                {
                    _memoryCache.Set("addressDtos", addresses, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("addressDtos returned from database, and cached in memory successfully.");
                    return addresses;
                }
                else
                {
                    _logger.LogError("We expected the addressDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("addressDtos returned from InMemoryCache.");
            return addresses;
        }

        //public async Task<Address> HardDeleteAddress(int addressId, CancellationToken cancellationToken)
        //{
        //    var deletedAddress = await GetAddress(addressId, cancellationToken);
        //    if (deletedAddress != null)
        //    {
        //        deletedAddress.IsDeleted = true;
        //        _homeServiceDbContext.Addresses.Remove(deletedAddress);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedAddress;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<AddressSoftDeleteDto> SoftDeleteAddress(int addressId, CancellationToken cancellationToken)
        {
            var deletedAddress = await GetAddressSoftDeleteDto(addressId, cancellationToken);
            
            deletedAddress.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Address has been successfully deleted.");
            return deletedAddress;
        }

        public async Task<AddressDto> UpdateAddress(Address updatedAddress, CancellationToken cancellationToken)
        {
            var updatingAddress = await GetAddressDto(updatedAddress.Id, cancellationToken);
            
            updatingAddress.Street = updatedAddress.Street;
            updatingAddress.PostalCode = updatedAddress.PostalCode;
            updatingAddress.CityId = (int)updatedAddress.CityId;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingAddress;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.DTOs.AddressDto> GetAddressDto(int addressId, CancellationToken cancellationToken)
        {
            var address = _memoryCache.Get<AddressDto>("addressDto");
            if (address is null)
            {
                address = await _homeServiceDbContext.Addresses
                .Select(a => new Domain.Core.Customer.DTOs.AddressDto
                {
                    Street = a.Street,
                    PostalCode = a.PostalCode,
                    CityId = (int)a.CityId,
                }).FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);

                if (address != null)
                {
                    _memoryCache.Set("addressDto", address, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("AddressDto has been returned form database and cached in memory successfully.");
                    return address;
                }
                _logger.LogError($"address with id {addressId} not found in GetAddressDto method.");
                throw new Exception($"address with id {addressId} not found.");
            }
            _logger.LogInformation("AddressDto returned from InMemeoryCache in GetAddressDto method.");
            return address;
        }

        private async Task<AddressSoftDeleteDto> GetAddressSoftDeleteDto(int addressId, CancellationToken cancellationToken)
        {
            var address = _memoryCache.Get<AddressSoftDeleteDto>("addressSoftDeleteDto");
            if (address is null)
            {
                address = await _homeServiceDbContext.Addresses
                .Select(a => new AddressSoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);

                if (address != null)
                {
                    _memoryCache.Set("addressSoftDeleteDto", address, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("addressSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return address;
                }
                _logger.LogError($"address with id {addressId} not found in GetAddressSoftDeleteDto method.");
                throw new Exception($"address with id {addressId} not found.");
            }
            _logger.LogInformation("addressSoftDeleteDto returned from InMemeoryCache in GetAddressSoftDeleteDto method.");
            return address;

        }
        #endregion
    }
}
