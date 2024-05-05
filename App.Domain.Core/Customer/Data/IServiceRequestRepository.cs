using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface IServiceRequestRepository
    {
        public Task<Customer.Entities.ServiceRequest> CreateServiceRequest(Customer.Entities.ServiceRequest submittedServiceRequest, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> UpdateServiceRequest(ServiceRequest updatedServiceRequest, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.ServiceRequest> GetServiceRequestById(int serviceId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.ServiceRequest>> GetServiceRequests(CancellationToken cancellationToken);
    }
}
