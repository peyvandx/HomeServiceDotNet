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
    public class ServiceRequestRepository : IServiceRequestRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public ServiceRequestRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<ServiceRequest> CreateServiceRequest(ServiceRequest submittedServiceRequest, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.ServiceRequests.AddAsync(submittedServiceRequest, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedServiceRequest;
        }

        public async Task<ServiceRequest> GetServiceRequestById(int serviceRequestId, CancellationToken cancellationToken)
        {
            var serviceRequest = await _homeServiceDbContext.ServiceRequests.FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);
            if (serviceRequest != null)
            {
                return serviceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<ServiceRequest>> GetServiceRequests(CancellationToken cancellationToken) => await _homeServiceDbContext.ServiceRequests.ToListAsync(cancellationToken);
        //{
        //    var serviceRequests = _homeServiceDbContext.ServiceRequests.ToListAsync();
        //    if (serviceRequests != null)
        //    {
        //        return serviceRequests;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<ServiceRequest> HardDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        {
            var deletedServiceRequest = await GetServiceRequest(serviceRequestId, cancellationToken);
            if (deletedServiceRequest != null)
            {
                deletedServiceRequest.IsDeleted = true;
                _homeServiceDbContext.ServiceRequests.Remove(deletedServiceRequest);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<ServiceRequest> SoftDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        {
            var deletedServiceRequest = await GetServiceRequest(serviceRequestId, cancellationToken);
            if (deletedServiceRequest != null)
            {
                deletedServiceRequest.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<ServiceRequest> UpdateServiceRequest(ServiceRequest updatedServiceRequest, CancellationToken cancellationToken)
        {
            var updatingServiceRequest = await GetServiceRequest(updatedServiceRequest.Id, cancellationToken);
            if (updatingServiceRequest != null)
            {
                updatingServiceRequest.CustomerDescription = updatedServiceRequest.CustomerDescription;
                updatingServiceRequest.Price = updatedServiceRequest.Price;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.ServiceRequest> GetServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        {
            var serviceRequest = await _homeServiceDbContext.ServiceRequests
                .FirstOrDefaultAsync(a => a.Id == serviceRequestId, cancellationToken);

            if (serviceRequest != null)
            {
                return serviceRequest;
            }

            throw new Exception($"admin with id {serviceRequestId} not found");
        }
        #endregion
    }
}
