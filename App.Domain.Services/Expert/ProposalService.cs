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
    public class ProposalService : IProposalService
    {
        #region Fields
        private readonly IProposalRepository _proposalRepository;
        #endregion

        #region Ctors
        public ProposalService(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }
        #endregion

        #region Implementations
        public async Task<Proposal> CreateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
        {
            var creatingProposal = new Proposal();
            creatingProposal.CreatedAt = DateTime.Now;
            creatingProposal.ExpertDescription = proposalDto.ExpertDescription;
            creatingProposal.SuggestedPrice = proposalDto.SuggestedPrice;
            creatingProposal.ExpertId = proposalDto.ExpertId;
            creatingProposal.ServiceRequestId = proposalDto.ServiceRequestId;
            return await _proposalRepository.CreateProposal(creatingProposal, cancellationToken);
        }


        public async Task<ProposalDto> GetProposalById(int proposalId, CancellationToken cancellationToken)
            => await _proposalRepository.GetProposalById(proposalId, cancellationToken);

        public async Task<List<ProposalDto>> GetProposals(CancellationToken cancellationToken)
            => await _proposalRepository.GetProposals(cancellationToken);

        //public async Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        //    => await _proposalRepository.HardDeleteProposal(proposalId, cancellationToken);


        public async Task<ProposalSoftDeleteDto> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
            => await _proposalRepository.SoftDeleteProposal(proposalId, cancellationToken);


        public async Task<ProposalDto> UpdateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
        {
            var updatedProposal = new Proposal();
            updatedProposal.ExpertDescription = proposalDto.ExpertDescription;
            updatedProposal.SuggestedPrice = proposalDto.SuggestedPrice;
            return await _proposalRepository.UpdateProposal(updatedProposal, cancellationToken);
        }

        #endregion
    }
}
