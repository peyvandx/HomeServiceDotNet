using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class ServiceRequestService : IServiceRequestService
    {
        #region Fields
        private readonly IServiceRequestRepository _serviceRequestRepository;
        #endregion

        #region Ctors
        public ServiceRequestService(IServiceRequestRepository serviceRequestRepository)
        {
            _serviceRequestRepository = serviceRequestRepository;
        }

        #endregion

        #region Implementations
        public async Task<ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
        {
            var creatingServiceRequest = new ServiceRequest();
            creatingServiceRequest.CreatedAt = DateTime.Now;
            creatingServiceRequest.Status = Status.WaitingForExpertsProposals;
            creatingServiceRequest.CustomerDescription = serviceRequestDto.CustomerDescription;
            creatingServiceRequest.Price = serviceRequestDto.Price;
            creatingServiceRequest.CustomerId = serviceRequestDto.CustomerId;
            creatingServiceRequest.ExpertId = serviceRequestDto.ExpertId;
            creatingServiceRequest.ServiceId = serviceRequestDto.ServiceId;
            return await _serviceRequestRepository.CreateServiceRequest(creatingServiceRequest, cancellationToken);
        }

        public async Task<ServiceRequestDto> GetServiceRequestById(int serviceRequestId, CancellationToken cancellationToken)
            => await _serviceRequestRepository.GetServiceRequestById(serviceRequestId, cancellationToken);

        public async Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken)
            => await _serviceRequestRepository.GetServiceRequests(cancellationToken);

        //public async Task<ServiceRequest> HardDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        //    => await _serviceRequestRepository.HardDeleteServiceRequest(serviceRequestId, cancellationToken);

        public async Task<ServiceRequestSoftDeleteDto> SoftDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
            => await _serviceRequestRepository.SoftDeleteServiceRequest(serviceRequestId, cancellationToken);

        public async Task<ServiceRequestDto> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
        {
            var updatedServiceRequest = new ServiceRequest();
            updatedServiceRequest.CustomerDescription = serviceRequestDto.CustomerDescription;
            updatedServiceRequest.Price = serviceRequestDto.Price;
            return await _serviceRequestRepository.UpdateServiceRequest(updatedServiceRequest, cancellationToken);
        }

        public async Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken)
            => await _serviceRequestRepository.ChangeServiceRequestStatus(newStatus, cancellationToken);

        #endregion
    }
}
