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
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<CustomerRepository> _logger;
        #endregion

        #region Ctors
        public CustomerRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<CustomerRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Domain.Core.Customer.Entities.Customer> CreateCustomer(Domain.Core.Customer.Entities.Customer signingUpCustomer, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Customers.AddAsync(signingUpCustomer, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Admin has been successfully added to the database.");
            return signingUpCustomer;
        }

        public async Task<CustomerDto> GetCustomerById(int? customerId, CancellationToken cancellationToken)
        {
            var customer = _memoryCache.Get<CustomerDto?>("customerDto");
            if (customer is null)
            {
                customer = await _homeServiceDbContext.Customers
                 .Include(c => c.Address)
                 .ThenInclude(a => a.City)
                .Select(a => new CustomerDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                    Address = a.Address,
                    AboutMe = a.AboutMe,
                    InstagramAddress = a.InstagramAddress,
                    FacebookAddress = a.FacebookAddress,
                    TwitterAddress = a.TwitterAddress,
                    LinkedinAddress = a.LinkedinAddress,
                }).FirstOrDefaultAsync(a => a.Id == customerId, cancellationToken);

                if (customer != null)
                {
                    _memoryCache.Set("customerDto", customer, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(1)
                    });
                    _logger.LogInformation("customerDto returned from database, and cached in memory successfully.");
                    return customer;
                }
                else
                {
                    _logger.LogError("We expected the customerDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("customerDto returned from InMemoryCache.");
            return customer;
        }

        public Task<int?> GetCustomerIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
        {
            var customerId = _homeServiceDbContext.Customers
                .Where(c => c.ApplicationUserId == applicationUserId)
                .Select(c => c.Id)
                .FirstOrDefaultAsync(cancellationToken);

            return customerId;
        }

        public Task<int> GetCustomerIdFromUserId(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Domain.Core.Customer.DTOs.CustomerDto>> GetCustomers(CancellationToken cancellationToken)
        {
            var customers = _memoryCache.Get<List<CustomerDto>>("customerDtos");

            if (customers is null)
            {
                customers = await _homeServiceDbContext.Customers
                .Select(c => new CustomerDto()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    ProfileImage = c.ProfileImage,
                }).ToListAsync(cancellationToken);

                if (customers is null)
                {
                    _logger.LogError("We expected the customerDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("customerDtos", customers, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("customerDtos returned from database, and cached in memory successfully.");
                    return customers;
                }
            }
            _logger.LogInformation("customerDtos returned from InMemoryCache.");
            return customers;
        }

        //public async  Task<Domain.Core.Customer.Entities.Customer> HardDeleteCustomer(int customerId, CancellationToken cancellationToken)
        //{
        //    var deletedCustomer = await GetCustomer(customerId, cancellationToken);
        //    if (deletedCustomer != null)
        //    {
        //        deletedCustomer.IsDeleted = true;
        //        _homeServiceDbContext.Customers.Remove(deletedCustomer);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedCustomer;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Domain.Core.Customer.DTOs.CustomerSoftDeleteDto> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken)
        {
            var deletedCustomer = await GetCustomerSoftDeleteDto(customerId, cancellationToken);
            deletedCustomer.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedCustomer;
        }

        public async Task<Domain.Core.Customer.Entities.Customer> UpdateCustomer(Domain.Core.Customer.DTOs.CustomerProfileDto updatedCustomer, CancellationToken cancellationToken)
        {
            var updatingCustomer = await GetCustomer(updatedCustomer.Id.Value, cancellationToken);
            updatingCustomer.Address = new Address();
            //updatingCustomer.Address.City.Province = new Province();
            updatingCustomer.FirstName = updatedCustomer.FirstName;
            updatingCustomer.LastName = updatingCustomer.LastName;
            updatingCustomer.ProfileImage = updatedCustomer.ProfileImageUrl;
            updatingCustomer.AboutMe = updatedCustomer.AboutMe;
            updatingCustomer.ApplicationUser.Email = updatedCustomer.Email;
            updatingCustomer.ApplicationUser.NormalizedEmail = updatedCustomer.Email.ToUpper();
            updatingCustomer.ApplicationUser.PhoneNumber = updatedCustomer.PhoneNumber;
            updatingCustomer.FacebookAddress = updatedCustomer.FacebookAddress;
            updatingCustomer.InstagramAddress = updatedCustomer.InstagramAddress;
            updatingCustomer.TwitterAddress = updatedCustomer.TwitterAddress;
            updatingCustomer.LinkedinAddress = updatedCustomer.LinkedinAddress;
            updatingCustomer.Address.Street = updatedCustomer.Address.Street;
            updatingCustomer.Address.PostalCode = updatedCustomer.Address.PostalCode;
            updatingCustomer.Address.CityId = updatedCustomer.Address.CityId;
            //updatingCustomer.Address.City.ProvinceId = updatedCustomer.Address.City.ProvinceId;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingCustomer;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.Customer> GetCustomer(int customerId, CancellationToken cancellationToken)
        {
            //var customer = _memoryCache.Get<Domain.Core.Customer.Entities.Customer>("customerDto");
            //if (customer is null)
            //{
            //    customer = await _homeServiceDbContext.Customers
            //    .Include(c => c.Address)
            //    .ThenInclude(a => a.City)
            //    .FirstOrDefaultAsync(c => c.Id == customerId, cancellationToken);

            //    if (customer != null)
            //    {
            //        _memoryCache.Set("customerDto", customer, new MemoryCacheEntryOptions()
            //        {
            //            SlidingExpiration = TimeSpan.FromSeconds(120)
            //        });
            //        _logger.LogInformation("customerDto has been returned form database and cached in memory successfully.");
            //        return customer;
            //    }
            //    _logger.LogError($"admin with id {customerId} not found in GetCustomerDto method.");
            //    throw new Exception($"admin with id {customerId} not found.");
            //}
            //_logger.LogInformation("customerDto returned from InMemeoryCache in GetCustomerDto method.");
            //return customer;

            try
            {
                var customer = await _homeServiceDbContext.Customers
                .Include(c => c.ApplicationUser)
                .Include(c => c.Address)
                .ThenInclude(a => a.City)
                .FirstOrDefaultAsync(c => c.Id == customerId, cancellationToken);

                if (customer is null)
                    throw new Exception("customer is null");
                else
                    return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private async Task<CustomerSoftDeleteDto> GetCustomerSoftDeleteDto(int customerId, CancellationToken cancellationToken)
        {
            var customer = _memoryCache.Get<CustomerSoftDeleteDto>("customerSoftDeleteDto");
            if (customer is null)
            {
                customer = await _homeServiceDbContext.Customers
                .Select(c => new CustomerSoftDeleteDto()
                {
                    Id = c.Id.Value,
                    IsDeleted = c.IsDeleted
                }).FirstOrDefaultAsync(c => c.Id == customerId, cancellationToken);

                if (customer != null)
                {
                    _memoryCache.Set("customerSoftDeleteDto", customer, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("customerSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return customer;
                }
                _logger.LogError($"admin with id {customerId} not found in GetCustomerSoftDeleteDto method.");
                throw new Exception($"admin with id {customerId} not found.");
            }
            _logger.LogInformation("customerSoftDeleteDto returned from InMemeoryCache in GetCustomerSoftDeleteDto method.");
            return customer;

        }
        #endregion
    }
}
