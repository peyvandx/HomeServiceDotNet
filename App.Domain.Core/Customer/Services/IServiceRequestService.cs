using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Services
{
    public interface IServiceRequestService
    {
        public Task<Customer.Entities.ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken);
        public Task<ServiceRequestDto> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken);
        public Task<ServiceRequestSoftDeleteDto> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        public Task<ServiceRequestDto> GetServiceRequestById(int serviceId, CancellationToken cancellationToken);
        public Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken);
        public Task<List<ServiceRequestDto>> GetCustomerServiceRequests(int customerId, CancellationToken cancellationToken);
        public Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken);

    }
}
