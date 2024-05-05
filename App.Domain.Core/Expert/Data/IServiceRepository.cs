using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface IServiceRepository
    {
        public Task<Expert.Entities.Service> CreateService(Expert.Entities.Service createdService, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> UpdateService(Expert.Entities.Service updatedService, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> SoftDeleteService(int serviceId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> HardDeleteService(int serviceId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Service> GetServiceById(int serviceId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Service>> GetServices(CancellationToken cancellationToken);
    }
}
