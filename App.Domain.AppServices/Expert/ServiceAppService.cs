using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class ServiceAppService : IServiceAppService
    {
        #region Fields
        private readonly IServiceService _serviceService;
        #endregion

        #region Ctors
        public ServiceAppService(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        #endregion

        #region Implementations
        public async Task<Service> CreateService(ServiceDto serviceDto, CancellationToken cancellationToken)
            => await _serviceService.CreateService(serviceDto, cancellationToken);

        public async Task<Service> GetServiceById(int serviceId, CancellationToken cancellationToken)
            => await _serviceService.GetServiceById(serviceId, cancellationToken);

        public async Task<List<Service>> GetServices(CancellationToken cancellationToken)
            => await _serviceService.GetServices(cancellationToken);

        public async Task<Service> HardDeleteService(int serviceId, CancellationToken cancellationToken)
            => await _serviceService.HardDeleteService(serviceId, cancellationToken);

        public async Task<Service> SoftDeleteService(int serviceId, CancellationToken cancellationToken)
            => await _serviceService.SoftDeleteService(serviceId, cancellationToken);

        public async Task<Service> UpdateService(ServiceDto serviceDto, CancellationToken cancellationToken)
            => await _serviceService.UpdateService(serviceDto, cancellationToken);
        #endregion
    }
}
