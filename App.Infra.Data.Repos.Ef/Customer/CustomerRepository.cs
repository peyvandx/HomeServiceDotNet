using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
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
        #endregion

        #region Ctors
        public CustomerRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async  Task<Domain.Core.Customer.Entities.Customer> CreateCustomer(Domain.Core.Customer.Entities.Customer signingUpCustomer, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Customers.AddAsync(signingUpCustomer, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return signingUpCustomer;
        }

        public async  Task<Domain.Core.Customer.Entities.Customer> GetCustomerById(int customerId, CancellationToken cancellationToken)
        {
            var customer = await _homeServiceDbContext.Customers.FirstOrDefaultAsync(c => c.Id == customerId, cancellationToken);
            if (customer != null)
            {
                return customer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async  Task<List<Domain.Core.Customer.Entities.Customer>> GetCustomers(CancellationToken cancellationToken) => await _homeServiceDbContext.Customers.ToListAsync(cancellationToken);
        //{
        //    var customers = await _homeServiceDbContext.Customers.ToListAsync(cancellationToken);
        //    if (customers != null)
        //    {
        //        return customers;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async  Task<Domain.Core.Customer.Entities.Customer> HardDeleteCustomer(int customerId, CancellationToken cancellationToken)
        {
            var deletedCustomer = await GetCustomer(customerId, cancellationToken);
            if (deletedCustomer != null)
            {
                deletedCustomer.IsDeleted = true;
                _homeServiceDbContext.Customers.Remove(deletedCustomer);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async  Task<Domain.Core.Customer.Entities.Customer> SoftDeleteCustomer(int customerId, CancellationToken cancellationToken)
        {
            var deletedCustomer = await GetCustomer(customerId, cancellationToken);
            if (deletedCustomer != null)
            {
                deletedCustomer.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async  Task<Domain.Core.Customer.Entities.Customer> UpdateCustomer(Domain.Core.Customer.Entities.Customer updatedCustomer, CancellationToken cancellationToken)
        {
            var updatingCustomer = await GetCustomer(updatedCustomer.Id, cancellationToken);
            if (updatingCustomer != null)
            {
                updatingCustomer.FirstName = updatedCustomer.FirstName;
                updatingCustomer.LastName = updatingCustomer.LastName;
                updatingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;
                updatingCustomer.ProfileImage = updatedCustomer.ProfileImage;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.Customer> GetCustomer(int customerId, CancellationToken cancellationToken)
        {
            var customer = await _homeServiceDbContext.Customers
                .FirstOrDefaultAsync(a => a.Id == customerId, cancellationToken);

            if (customer != null)
            {
                return customer;
            }

            throw new Exception($"admin with id {customerId} not found");
        }
        #endregion
    }
}
