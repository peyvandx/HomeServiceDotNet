using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class ServiceRequestAppService : IServiceRequestAppService
    {
        public Task<ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRequest> GetServiceRequestById(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceRequest>> GetServiceRequests(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRequest> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRequest> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
