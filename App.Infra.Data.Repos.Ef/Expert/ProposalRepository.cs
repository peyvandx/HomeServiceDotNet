using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
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
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProposalRepository> _logger;
        #endregion

        #region Ctors
        public ProposalRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ProposalRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Proposal> CreateProposal(Proposal submittedProposal, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Proposals.AddAsync(submittedProposal, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Proposal has been successfully added to the database.");
            return submittedProposal;
        }

        public async Task<ProposalDto> GetProposalById(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = _memoryCache.Get<ProposalDto>("proposalDto");
            if (proposal is null)
            {
                proposal = await _homeServiceDbContext.Proposals
                .Select(a => new Domain.Core.Expert.DTOs.ProposalDto
                {
                    Id = a.Id,
                    ExpertDescription = a.ExpertDescription,
                    SuggestedPrice = a.SuggestedPrice,
                }).FirstOrDefaultAsync(a => a.Id == proposalId, cancellationToken);

                if (proposal != null)
                {
                    _memoryCache.Set("proposalDto", proposal, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("proposalDto returned from database, and cached in memory successfully.");
                    return proposal;
                }
                else
                {
                    _logger.LogError("We expected the proposalDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("proposalDto returned from InMemoryCache.");
            return proposal;
        }

        public async Task<List<ProposalDto>> GetProposals(CancellationToken cancellationToken)
        {
            var proposals = _memoryCache.Get<List<ProposalDto>>("proposalDtos");

            if (proposals is null)
            {
                proposals = await _homeServiceDbContext.Proposals
                .Select(a => new ProposalDto()
                {
                    Id = a.Id,
                    ExpertDescription = a.ExpertDescription,
                    SuggestedPrice = a.SuggestedPrice,
                }).ToListAsync(cancellationToken);

                if (proposals is null)
                {
                    _logger.LogError("We expected the proposalDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("proposalDtos", proposals, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("proposalDtos returned from database, and cached in memory successfully.");
                    return proposals;
                }
            }
            _logger.LogInformation("proposalDtos returned from InMemoryCache.");
            return proposals;
        }
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

        //public async Task<Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken)
        //{
        //    var deletedProposal = await GetProposal(proposalId, cancellationToken);
        //    if (deletedProposal != null)
        //    {
        //        deletedProposal.IsDeleted = true;
        //        _homeServiceDbContext.Proposals.Remove(deletedProposal);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedProposal;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<ProposalSoftDeleteDto> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken)
        {
            var deletedProposal = await GetProposalSoftDeleteDto(proposalId, cancellationToken);
            deletedProposal.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedProposal;
        }

        public async Task<ProposalDto> UpdateProposal(Proposal updatedProposal, CancellationToken cancellationToken)
        {
            var updatingProposal = await GetProposalDto(updatedProposal.Id, cancellationToken);
            updatingProposal.ExpertDescription = updatedProposal.ExpertDescription;
            updatingProposal.SuggestedPrice = updatedProposal.SuggestedPrice;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingProposal;
        }
        #endregion

        #region PrivateFields
        private async Task<Domain.Core.Expert.DTOs.ProposalDto> GetProposalDto(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = _memoryCache.Get<ProposalDto>("proposalDto");
            if (proposal is null)
            {
                proposal = await _homeServiceDbContext.Proposals
                .Select(a => new ProposalDto()
                {
                    Id = a.Id,
                    ExpertDescription = a.ExpertDescription,
                    SuggestedPrice = a.SuggestedPrice
                }).FirstOrDefaultAsync(a => a.Id == proposalId, cancellationToken);

                if (proposal != null)
                {
                    _memoryCache.Set("proposalDto", proposal, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("proposalDto has been returned form database and cached in memory successfully.");
                    return proposal;
                }
                _logger.LogError($"proposal with id {proposalId} not found in GetProposalDto method.");
                throw new Exception($"proposal with id {proposalId} not found.");
            }
            _logger.LogInformation("proposalDto returned from InMemeoryCache in GetProposalDto method.");
            return proposal;
        }

        private async Task<Domain.Core.Expert.DTOs.ProposalSoftDeleteDto> GetProposalSoftDeleteDto(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = _memoryCache.Get<Domain.Core.Expert.DTOs.ProposalSoftDeleteDto>("proposalSoftDeleteDto");
            if (proposal is null)
            {
                proposal = await _homeServiceDbContext.Proposals
                .Select(a => new Domain.Core.Expert.DTOs.ProposalSoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == proposalId, cancellationToken);

                if (proposal != null)
                {
                    _memoryCache.Set("proposalSoftDeleteDto", proposal, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("proposalSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return proposal;
                }
                _logger.LogError($"proposal with id {proposalId} not found in GetProposalSoftDeleteDto method.");
                throw new Exception($"proposal with id {proposalId} not found.");
            }
            _logger.LogInformation("proposalSoftDeleteDto returned from InMemeoryCache in GetProposalSoftDeleteDto method.");
            return proposal;

        }
        #endregion
    }
}
