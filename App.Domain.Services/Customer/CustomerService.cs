using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Customer.Services;
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
        #endregion

        #region Ctors
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
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

        public async Task<CustomerDto> GetCustomerById(int customerId, CancellationToken cancellationToken)
            => await _customerRepository.GetCustomerById(customerId, cancellationToken);

        public async Task<List<CustomerDto>> GetCustomers(CancellationToken cancellationToken)
            => await _customerRepository.GetCustomers(cancellationToken);

        //public async Task<CommentDto> HardDeleteCustomer(int customerId, CancellationToken cancellationToken)
        //    => await _customerRepository.HardDeleteCustomer(customerId, cancellationToken);
                          
        public async Task<CustomerSoftDeleteDto> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken)
            => await _customerRepository.SoftDeleteCustomer(customerId, cancellationToken);
                          
        public async Task<CustomerDto> UpdateCustomer(CustomerDto customerDto, CancellationToken cancellationToken)
        {
            var updatedCustomer = new Core.Customer.Entities.Customer();
            updatedCustomer.FirstName = customerDto.FirstName;
            updatedCustomer.LastName = customerDto.LastName;
            updatedCustomer.ProfileImage = customerDto.ProfileImage;
            return await _customerRepository.UpdateCustomer(updatedCustomer, cancellationToken);
        }

        #endregion
    }
}
