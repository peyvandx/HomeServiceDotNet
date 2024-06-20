using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Customer.Services;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Enums;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class ServiceRequestAppService : IServiceRequestAppService
    {
        #region Fields
        private readonly IServiceRequestService _serviceRequestService;
        private readonly IProposalService _proposalService;
        #endregion

        #region Ctors
        public ServiceRequestAppService(IServiceRequestService serviceRequestService,
            IProposalService proposalService)
        {
            _serviceRequestService = serviceRequestService;
            _proposalService = proposalService;
        }

        #endregion

        #region Implementations
        public async Task<ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
            => await _serviceRequestService.CreateServiceRequest(serviceRequestDto, cancellationToken);

        public async Task<ServiceRequestDto> GetServiceRequestById(int serviceId, CancellationToken cancellationToken)
            => await _serviceRequestService.GetServiceRequestById(serviceId, cancellationToken);

        public async Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken)
            => await _serviceRequestService.GetServiceRequests(cancellationToken);

        //public async Task<ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
        //    => await _serviceRequestService.HardDeleteServiceRequest(serviceId, cancellationToken);

        public async Task<ServiceRequestSoftDeleteDto> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
            => await _serviceRequestService.SoftDeleteServiceRequest(serviceId, cancellationToken);

        public async Task<ServiceRequestDto> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
            => await _serviceRequestService.UpdateServiceRequest(serviceRequestDto, cancellationToken);

        public async Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken)
            => await _serviceRequestService.ChangeServiceRequestStatus(newStatus, cancellationToken);

		public async Task<List<ServiceRequestDto>> GetCustomerServiceRequests(int? customerId, CancellationToken cancellationToken)
		    => await _serviceRequestService.GetCustomerServiceRequests(customerId, cancellationToken);

		public async Task<List<ServiceRequestDto>> GetExpertRelatedServiceRequests(int expertId, CancellationToken cancellationToken)
		    => await _serviceRequestService.GetExpertRelatedServiceRequests(expertId, cancellationToken);

        public async Task<bool> ServiceRequestDoneSuccessfully(RequestProposalIdsDto serviceRequestProposalIds, CancellationToken cancellationToken)
        {
            var serviceRequestNewStatus = new ServiceRequestChangeStatusDto()
            {
                ServiceRequestId = serviceRequestProposalIds.ServiceRequestId,
                ExpertId = serviceRequestProposalIds.ProposalExpertId,
                NewStatus = ServiceRequestStatus.Success,
            };
            await _serviceRequestService.ChangeServiceRequestStatus(serviceRequestNewStatus, cancellationToken);
            var proposalNewStatus = new ChangeProposalStatusDto()
            {
                ProposalId = serviceRequestProposalIds.ProposalId,
                NewStatus = ProposalStatus.Success,
            };
            await _proposalService.ChangeProposalStatus(proposalNewStatus, cancellationToken);
            return true;
        }

        public async Task<bool> ServiceRequestDoneUnSuccessfully(RequestProposalIdsDto serviceRequestProposalIds, CancellationToken cancellationToken)
        {
            var serviceRequestNewStatus = new ServiceRequestChangeStatusDto()
            {
                ServiceRequestId = serviceRequestProposalIds.ServiceRequestId,
                NewStatus = ServiceRequestStatus.Failed,
            };
            await _serviceRequestService.ChangeServiceRequestStatus(serviceRequestNewStatus, cancellationToken);
            var proposalNewStatus = new ChangeProposalStatusDto()
            {
                ProposalId = serviceRequestProposalIds.ProposalId,
                NewStatus = ProposalStatus.Failed,
            };
            await _proposalService.ChangeProposalStatus(proposalNewStatus, cancellationToken);
            return true;
        }
        #endregion
    }
}
