using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class ProposalRepository : IProposalRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public ProposalRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Proposal> CreateProposal(Proposal submittedProposal, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Proposals.AddAsync(submittedProposal, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedProposal;
        }

        public async Task<Proposal> GetProposalById(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = await _homeServiceDbContext.Proposals.FirstOrDefaultAsync(p => p.Id == proposalId, cancellationToken);
            if (proposal != null)
            {
                return proposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Proposal>> GetProposals(CancellationToken cancellationToken) => await _homeServiceDbContext.Proposals.ToListAsync(cancellationToken);
        //{
        //    var proposals = await _homeServiceDbContext.Proposals.ToListAsync(cancellationToken);
        //    if (proposals != null)
        //    {
        //        return proposals;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        {
            var deletedProposal = await GetProposal(proposalId, cancellationToken);
            if (deletedProposal != null)
            {
                deletedProposal.IsDeleted = true;
                _homeServiceDbContext.Proposals.Remove(deletedProposal);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Proposal> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
        {
            var deletedProposal = await GetProposal(proposalId, cancellationToken);
            if (deletedProposal != null)
            {
                deletedProposal.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Proposal> UpdateProposal(Proposal updatedProposal, CancellationToken cancellationToken)
        {
            var updatingProposal = await GetProposal(updatedProposal.Id, cancellationToken);
            if (updatingProposal != null)
            {
                updatingProposal.ExpertDescription = updatedProposal.ExpertDescription;
                updatingProposal.SuggestedPrice = updatedProposal.SuggestedPrice;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateFields
        private async Task<Domain.Core.Expert.Entities.Proposal> GetProposal(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = await _homeServiceDbContext.Proposals
                .FirstOrDefaultAsync(a => a.Id == proposalId, cancellationToken);

            if (proposal != null)
            {
                return proposal;
            }

            throw new Exception($"admin with id {proposalId} not found");
        }
        #endregion
    }
}
