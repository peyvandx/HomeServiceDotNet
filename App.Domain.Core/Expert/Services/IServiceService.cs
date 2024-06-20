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
        public Task<ServiceDto> UpdateService(ServiceDto serviceDto, CancellationToken cancellationToken);
        public Task<ServiceSoftDeleteDto> SoftDeleteService(int serviceId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Service> HardDeleteService(int serviceId, CancellationToken cancellationToken);
        public Task<ServiceDto> GetServiceById(int serviceId, CancellationToken cancellationToken);
		public Task<List<ServiceDto>> GetServicesByCategoryId(int categoryId, CancellationToken cancellationToken);
		public Task<List<ServiceDto>> GetServices(CancellationToken cancellationToken);
        public Task<bool> RestoreDeletedService(int serviceId, CancellationToken cancellationToken);
    }
}
