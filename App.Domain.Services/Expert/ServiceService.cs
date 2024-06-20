using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class ServiceService : IServiceService
    {
        #region Fields
        private readonly IServiceRepository _serviceRepository;
        #endregion

        #region Ctors
        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        #endregion

        #region Implementations
        public async Task<Service> CreateService(ServiceDto serviceDto, CancellationToken cancellationToken)
        {
            var creatingSevice = new Service();
            creatingSevice.CreatedAt = DateTime.Now;
            creatingSevice.Title = serviceDto.Title;
            creatingSevice.Description = serviceDto.Description;
            creatingSevice.ShortDescription = serviceDto.ShortDescription;
            creatingSevice.Image = serviceDto.Image;
            //creatingSevice.WorkExperience = serviceDto.WorkExperience;
            creatingSevice.CategoryId = serviceDto.CategoryId;
            return await _serviceRepository.CreateService(creatingSevice, cancellationToken);
        }

        public async Task<ServiceDto> GetServiceById(int serviceId, CancellationToken cancellationToken)
            => await _serviceRepository.GetServiceById(serviceId, cancellationToken);

        public async Task<List<ServiceDto>> GetServices(CancellationToken cancellationToken)
            => await _serviceRepository.GetServices(cancellationToken);

		public async Task<List<ServiceDto>> GetServicesByCategoryId(int categoryId, CancellationToken cancellationToken)
		    => await _serviceRepository.GetServicesByCategoryId(categoryId, cancellationToken);

        public async Task<bool> RestoreDeletedService(int serviceId, CancellationToken cancellationToken)
            => await _serviceRepository.RestoreDeletedService(serviceId, cancellationToken);

        //public async Task<Service> HardDeleteService(int serviceId, CancellationToken cancellationToken)
        //    => await _serviceRepository.HardDeleteService(serviceId, cancellationToken);

        public async Task<ServiceSoftDeleteDto> SoftDeleteService(int serviceId, CancellationToken cancellationToken)
            => await _serviceRepository.SoftDeleteService(serviceId, cancellationToken);

        public async Task<ServiceDto> UpdateService(ServiceDto serviceDto, CancellationToken cancellationToken)
        {
            var updatedService = new Service();
            updatedService.Id = serviceDto.Id;
            updatedService.Title = serviceDto.Title;
            updatedService.Description = serviceDto.Description;
            updatedService.ShortDescription = serviceDto.ShortDescription;
            updatedService.Image = serviceDto.Image;
            updatedService.CategoryId = serviceDto.CategoryId;
            //updatedService.WorkExperience = serviceDto.WorkExperience;
            return await _serviceRepository.UpdateService(updatedService, cancellationToken);
        }

        #endregion
    }
}
