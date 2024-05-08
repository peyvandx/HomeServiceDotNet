using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.AppServices
{
    public interface IServiceRequestAppService
    {
        public Task<Customer.Entities.ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> GetServiceRequestById(int serviceId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.ServiceRequest>> GetServiceRequests(CancellationToken cancellationToken);
    }
}
