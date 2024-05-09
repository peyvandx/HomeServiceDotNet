﻿using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface ICustomerRepository
    {
        public Task<Customer.Entities.Customer> CreateCustomer(Customer.Entities.Customer signingUpCustomer, CancellationToken cancellationToken);
        public Task<CustomerDto> UpdateCustomer(Customer.Entities.Customer updatedCustomer, CancellationToken cancellationToken);
        public Task<CustomerSoftDeleteDto> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.Customer> HardDeleteCustomer(int customerId, CancellationToken cancellationToken);
        public Task<CustomerDto> GetCustomerById(int customerId, CancellationToken cancellationToken);
        public Task<List<CustomerDto>> GetCustomers(CancellationToken cancellationToken);
    }
}
