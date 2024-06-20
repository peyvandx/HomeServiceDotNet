using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Customer.Services;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly ICustomerRepository _customerRepository;
        private readonly IMemoryCache _memoryCache;
        #endregion

        #region Ctors
        public CustomerService(ICustomerRepository customerRepository
            ,IMemoryCache memoryCache)
        {
            _customerRepository = customerRepository;
            _memoryCache = memoryCache;
        }
        #endregion

        #region Implementations
        public async Task<Core.Customer.Entities.Customer> CreateCustomer(CustomerDto customerDto, CancellationToken cancellationToken)
        {
            var signingUpCustomer = new Core.Customer.Entities.Customer();
            signingUpCustomer.SignUpDate = DateTime.Now;
            signingUpCustomer.FirstName = customerDto.FirstName;
            signingUpCustomer.LastName = customerDto.LastName;
            signingUpCustomer.ProfileImage = customerDto.ProfileImage;
            //signingUpCustomer.AdminId = customerDto.AdminId; //will fix later
            return await _customerRepository.CreateCustomer(signingUpCustomer, cancellationToken);
        }

        public async Task<CustomerDto> GetCustomerById(int? customerId, CancellationToken cancellationToken)
            => await _customerRepository.GetCustomerById(customerId, cancellationToken);

        public async Task<int?> GetCustomerIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
            => await _customerRepository.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);

        public Task<int> GetCustomerIdFromUserId(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerDto>> GetCustomers(CancellationToken cancellationToken)
            => await _customerRepository.GetCustomers(cancellationToken);

        //public async Task<CommentDto> HardDeleteCustomer(int customerId, CancellationToken cancellationToken)
        //    => await _customerRepository.HardDeleteCustomer(customerId, cancellationToken);
                          
        public async Task<CustomerSoftDeleteDto> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken)
            => await _customerRepository.SoftDeleteCustomer(customerId, cancellationToken);
                          
        public async Task<Domain.Core.Customer.Entities.Customer> UpdateCustomer(CustomerProfileDto customerDto, CancellationToken cancellationToken)
        {
            //var updatedCustomer = new Core.Customer.Entities.Customer();
            //updatedCustomer.Address = new Address();
            //updatedCustomer.Id = customerDto.Id;
            //updatedCustomer.FirstName = customerDto.FirstName;
            //updatedCustomer.LastName = customerDto.LastName;
            //updatedCustomer.ProfileImage = customerDto.ProfileImageUrl;
            //updatedCustomer.AboutMe = customerDto.AboutMe;
            //updatedCustomer.FacebookAddress = customerDto.FacebookAddress;
            //updatedCustomer.InstagramAddress = customerDto.InstagramAddress;
            //updatedCustomer.TwitterAddress = customerDto.TwitterAddress;
            //updatedCustomer.LinkedinAddress = customerDto.LinkedinAddress;
            //updatedCustomer.Address.Street = customerDto.Address.Street;
            //updatedCustomer.Address.PostalCode = customerDto.Address.PostalCode;
            //updatedCustomer.Address.CityId = customerDto.Address.CityId;
            _memoryCache.Remove("customerDto");
            return await _customerRepository.UpdateCustomer(customerDto, cancellationToken);
        }

        #endregion
    }
}
