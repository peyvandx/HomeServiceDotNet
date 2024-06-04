using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Customer.Services;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Enums;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class ProposalAppService : IProposalAppService
    {
        #region Fields
        private readonly IProposalService _proposalService;
        private readonly IServiceRequestService _serviceRequestService;
        #endregion

        #region Ctors
        public ProposalAppService(IProposalService proposalService,
            IServiceRequestService serviceRequestService)
        {
            _proposalService = proposalService;
            _serviceRequestService = serviceRequestService;
        }
        #endregion

        #region Implementations

        public async Task<bool> AcceptProposal(ProposalConfirmationDto proposalConfirmationDto, CancellationToken cancellationToken)
        {
            await _proposalService.AcceptProposal(proposalConfirmationDto.ProposalId, cancellationToken);
            var serviceRequestNewStatus = new ServiceRequestChangeStatusDto()
            {
                ServiceRequestId = proposalConfirmationDto.ServiceRequestId,
                NewStatus = ServiceRequestStatus.WaitingForExpert
            };
            await _serviceRequestService.ChangeServiceRequestStatus(serviceRequestNewStatus, cancellationToken);
            var proposalNewStatus = new ChangeProposalStatusDto()
            {
                ProposalId = proposalConfirmationDto.ProposalId,
                NewStatus = ProposalStatus.WaitingForExpert
            };
            await _proposalService.ChangeProposalStatus(proposalNewStatus, cancellationToken);
            return await _proposalService.RejectProposalsByServiceRequestId(proposalConfirmationDto.ServiceRequestId, cancellationToken);
        }
        public async Task<Proposal> CreateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
            => await _proposalService.CreateProposal(proposalDto, cancellationToken);

        public async Task<ProposalDto> GetProposalById(int proposalId, CancellationToken cancellationToken)
            => await _proposalService.GetProposalById(proposalId, cancellationToken);

        public async Task<List<ProposalDto>> GetProposals(CancellationToken cancellationToken)
            => await _proposalService.GetProposals(cancellationToken);

        public async Task<List<ProposalDto>> GetProposalsByExpertId(int? expertId, CancellationToken cancellationToken)
            => await _proposalService.GetProposalsByExpertId(expertId, cancellationToken);

        public async Task<List<ProposalDto>> GetProposalsByServiceRequestId(int? serviceRequestId, CancellationToken cancellationToken)
            => await _proposalService.GetProposalsByServiceRequestId(serviceRequestId, cancellationToken);

        public async Task<bool> RejectProposal(int proposalId, CancellationToken cancellationToken)
        {
            await _proposalService.RejectProposal(proposalId, cancellationToken);
            var proposalNewStatus = new ChangeProposalStatusDto()
            {
                ProposalId = proposalId,
                NewStatus = ProposalStatus.Rejected,
            };
            return await _proposalService.ChangeProposalStatus(proposalNewStatus, cancellationToken);
        }

        //public async Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        //    => await _proposalService.HardDeleteProposal(proposalId, cancellationToken);

        public async Task<ProposalSoftDeleteDto> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
            => await _proposalService.SoftDeleteProposal(proposalId, cancellationToken);

        public async Task<ProposalDto> UpdateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
            => await _proposalService.UpdateProposal(proposalDto, cancellationToken);
        #endregion
    }
}
