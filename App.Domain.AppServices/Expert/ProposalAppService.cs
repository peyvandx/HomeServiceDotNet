﻿using App.Domain.Core.Expert.AppServices;
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
    public class ProposalAppService : IProposalAppService
    {
        #region Fields
        private readonly IProposalService _proposalService;
        #endregion

        #region Ctors
        public ProposalAppService(IProposalService proposalService)
        {
            _proposalService = proposalService;
        }
        #endregion

        #region Implementations
        public async Task<Proposal> CreateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
            => await _proposalService.CreateProposal(proposalDto, cancellationToken);

        public async Task<ProposalDto> GetProposalById(int proposalId, CancellationToken cancellationToken)
            => await _proposalService.GetProposalById(proposalId, cancellationToken);

        public async Task<List<ProposalDto>> GetProposals(CancellationToken cancellationToken)
            => await _proposalService.GetProposals(cancellationToken);

        //public async Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        //    => await _proposalService.HardDeleteProposal(proposalId, cancellationToken);

        public async Task<ProposalSoftDeleteDto> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
            => await _proposalService.SoftDeleteProposal(proposalId, cancellationToken);

        public async Task<ProposalDto> UpdateProposal(ProposalDto proposalDto, CancellationToken cancellationToken)
            => await _proposalService.UpdateProposal(proposalDto, cancellationToken);
        #endregion
    }
}
