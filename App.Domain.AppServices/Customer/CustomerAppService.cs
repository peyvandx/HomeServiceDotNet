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
    public class CustomerAppService : ICustomerAppService
    {
        #region Fields
        private readonly ICustomerService _customerService;
        #endregion

        #region Ctors
        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        #region Implementations

        public async Task<Core.Customer.Entities.Customer> CreateCustomer(CustomerDto customerDto, CancellationToken cancellationToken)
            => await _customerService.CreateCustomer(customerDto, cancellationToken);

        public async Task<CustomerDto> GetCustomerById(int? customerId, CancellationToken cancellationToken)
            => await _customerService.GetCustomerById(customerId, cancellationToken);

        public async Task<int?> GetCustomerIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
            => await _customerService.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);

        public async Task<List<CustomerDto>> GetCustomers(CancellationToken cancellationToken)
            => await _customerService.GetCustomers(cancellationToken);

        //public async Task<Core.Customer.Entities.Customer> HardDeleteCustomer(int customerId, CancellationToken cancellationToken)
        //    => await _customerService.HardDeleteCustomer(customerId, cancellationToken);

        public async Task<CustomerSoftDeleteDto> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken)
            => await _customerService.SoftDeleteCustomer(customerId, cancellationToken);

        public async Task<Domain.Core.Customer.Entities.Customer> UpdateCustomer(CustomerProfileDto customerDto, CancellationToken cancellationToken)
            => await _customerService.UpdateCustomer(customerDto, cancellationToken);
        #endregion
    }
}
