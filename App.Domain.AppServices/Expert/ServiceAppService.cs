using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class ServiceAppService : IServiceAppService
    {
        public Task<Service> CreateService(ServiceDto serviceDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetServiceById(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> GetServices(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Service> HardDeleteService(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Service> SoftDeleteService(int serviceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Service> UpdateService(ServiceDto serviceDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
