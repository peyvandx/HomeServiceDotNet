using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class ProposalAppService : IProposalAppService
    {
        public Task<Proposal> CreateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Proposal> GetProposalById(int proposalId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Proposal>> GetProposals(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Proposal> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Proposal> UpdateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
