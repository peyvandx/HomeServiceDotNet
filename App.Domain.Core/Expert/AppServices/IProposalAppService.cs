using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.AppServices
{
    public interface IProposalAppService
    {
        public Task<Expert.Entities.Proposal> CreateProposal(ProposalDto proposalDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> UpdateProposal(ProposalDto proposalDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> GetProposalById(int proposalId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Proposal>> GetProposals(CancellationToken cancellationToken);
    }
}
