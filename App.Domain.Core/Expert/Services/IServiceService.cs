using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Services
{
    public interface IServiceService
    {
        public Task<Expert.Entities.Service> CreateService(ServiceDto serviceDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> UpdateService(ServiceDto serviceDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> SoftDeleteService(int serviceId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> HardDeleteService(int serviceId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> GetServiceById(int serviceId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Service>> GetServices(CancellationToken cancellationToken);
    }
}
