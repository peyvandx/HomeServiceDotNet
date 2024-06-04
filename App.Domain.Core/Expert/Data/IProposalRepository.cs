using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface IProposalRepository
    {
        public Task<bool> AcceptProposal(int proposalId, CancellationToken cancellationToken);
        public Task<bool> RejectProposal(int proposalId, CancellationToken cancellationToken);
        public Task<bool> RejectProposalsByServiceRequestId(int serviceRequestId, CancellationToken cancellationToken);
        public Task<bool> ChangeProposalStatus(ChangeProposalStatusDto changeProposalStatusDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> CreateProposal(Expert.Entities.Proposal submittedProposal, CancellationToken cancellationToken);
        public Task<ProposalDto> UpdateProposal(Expert.Entities.Proposal updatedProposal, CancellationToken cancellationToken);
        public Task<ProposalSoftDeleteDto> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken);
        public Task<ProposalDto> GetProposalById(int proposalId, CancellationToken cancellationToken);
        public Task<List<ProposalDto>> GetProposalsByServiceRequestId(int? serviceRequestId, CancellationToken cancellationToken);
        public Task<List<ProposalDto>> GetProposalsByExpertId(int? expertId, CancellationToken cancellationToken);
        public Task<List<int?>> GetExpetProposalsServiceRequestIds(int? expertId, CancellationToken cancellationToken);
        public Task<List<ProposalDto>> GetProposals(CancellationToken cancellationToken);
    }
}
