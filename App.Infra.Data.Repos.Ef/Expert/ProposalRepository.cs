using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Enums;
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

        public async Task<bool> AcceptProposal(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = await _homeServiceDbContext.Proposals
                .FirstOrDefaultAsync(p => p.Id == proposalId, cancellationToken);

            if (proposal is not null)
            {
                proposal.IsAccepted = true;
            }
            else
            {
                throw new Exception($"proposal with id {proposalId} not found!");
            }

            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> RejectProposalsByServiceRequestId(int serviceRequestId, CancellationToken cancellationToken)
        {
            List<Proposal> proposals = await GetProposalsByServiceRequestId(serviceRequestId, cancellationToken);

            foreach (var proposal in proposals)
            {
                proposal.IsRejected = true;
                proposal.Status = ProposalStatus.NotAccepted;
            }

            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    ExpertSuggestedPrice = a.SuggestedPrice,
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
                    ExpertSuggestedPrice = a.SuggestedPrice,
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

        public async Task<List<ProposalDto>> GetProposalsByExpertId(int? expertId, CancellationToken cancellationToken)
        {
            var proposals = await _homeServiceDbContext.Proposals
                .Where(p => p.ExpertId == expertId && p.IsDeleted == false)
                .Include(p => p.Expert)
                .ThenInclude(e => e.ApplicationUser)
                .Include(p => p.ServiceRequest)
                .ThenInclude(sr => sr.Customer)
                .ThenInclude(c => c.ApplicationUser)
                .Include(p => p.ServiceRequest)
                .ThenInclude(sr => sr.Service)
                .ThenInclude(s => s.Category)
                .Select(p => new ProposalDto()
                {
                    Id = p.Id,
                    ExpertId = p.ExpertId,
                    ExpertFirstName = p.Expert.FirstName,
                    ExpertLastName = p.Expert.LastName,
                    ExpertDescription = p.ExpertDescription,
                    ExpertSignUpDate = p.Expert.SignUpDate,
                    ExpertProfileImage = p.Expert.ProfileImage,
                    ExpertSuggestedPrice = p.SuggestedPrice,
                    ExpertEmail = p.Expert.ApplicationUser.Email,
                    ExpertPhoneNumber = p.Expert.ApplicationUser.PhoneNumber,
                    CustomerId = p.ServiceRequest.CustomerId,
                    CustomerFirstName = p.ServiceRequest.Customer.FirstName,
                    CustomerLastName = p.ServiceRequest.Customer.LastName,
                    CustomerDescription = p.ServiceRequest.CustomerDescription,
                    CustomerSignUpDate = p.ServiceRequest.Customer.SignUpDate,
                    CustomerProfileImage = p.ServiceRequest.Customer.ProfileImage,
                    CustomerSuggestedPrice = p.ServiceRequest.CustomerSuggestedPrice,
                    ProposalCreatedAt = p.CreatedAt,
                    ServiceRequestCreatedAt = p.ServiceRequest.CreatedAt,
                    CustomerEmail = p.ServiceRequest.Customer.ApplicationUser.Email,
                    CustomerPhoneNumber = p.ServiceRequest.Customer.ApplicationUser.PhoneNumber,
                    ProposalStatus = p.Status,
                    ServiceRequestStatus = p.ServiceRequest.Status,
                    IsAccepted = p.IsAccepted,
                    ServiceRequestId = p.ServiceRequestId,
                    ServiceRequestIsDeleted = p.ServiceRequest.IsDeleted,
                    ServiceName = p.ServiceRequest.Service.Title,
                    CategoryName = p.ServiceRequest.Service.Category.Title
                }).ToListAsync(cancellationToken);

            return proposals;
        }

        public async Task<List<int?>> GetExpetProposalsServiceRequestIds(int? expertId, CancellationToken cancellationToken)
        {
            return await _homeServiceDbContext.Proposals
                .Where(p => p.ExpertId == expertId)
                .Select(x => x.ServiceRequestId)
                .ToListAsync(cancellationToken);
        }

        public Task<List<ProposalDto>> GetProposalsByServiceRequestId(int? serviceRequestId, CancellationToken cancellationToken)
        {
            var proposals = _homeServiceDbContext.Proposals
                .Where(p => p.ServiceRequestId == serviceRequestId && p.IsRejected == false)
				.Include(p => p.Expert)
				.ThenInclude(e => e.ApplicationUser)
				.Include(p => p.ServiceRequest)
				.ThenInclude(sr => sr.Customer)
				.ThenInclude(c => c.ApplicationUser)
				.Include(p => p.ServiceRequest)
				.ThenInclude(sr => sr.Service)
				.ThenInclude(s => s.Category)
				.Select(p => new ProposalDto()
                {
					//Id = p.Id,
					//ExpertDescription = p.ExpertDescription,
					//ExpertSuggestedPrice = p.SuggestedPrice,
					//ProposalCreatedAt = p.CreatedAt,
					//IsAccepted = p.IsAccepted,
					//IsDeleted = p.IsDeleted,
					//IsRejected = p.IsRejected,
					//ExpertId = p.ExpertId,
					//ExpertFirstName = p.Expert.FirstName,
					//ExpertLastName = p.Expert.LastName,
					//ExpertSignUpDate = p.Expert.SignUpDate,
					//ExpertEmail = p.Expert.ApplicationUser.Email,
					//ExpertPhoneNumber = p.Expert.ApplicationUser.PhoneNumber,
					//ExpertProfileImage = p.Expert.ProfileImage,
					//CustomerDescription = p.ServiceRequest.CustomerDescription,
					//CustomerSuggestedPrice = p.ServiceRequest.CustomerSuggestedPrice,
					//CategoryName = p.ServiceRequest.Service.Category.Title,
					//ServiceName = p.ServiceRequest.Service.Title,
					//ServiceRequestId = p.ServiceRequestId,
					//ProposalStatus = p.Status,
					//ServiceRequestStatus = p.ServiceRequest.Status,
					Id = p.Id,
					ExpertId = p.ExpertId,
					ExpertFirstName = p.Expert.FirstName,
					ExpertLastName = p.Expert.LastName,
					ExpertDescription = p.ExpertDescription,
					ExpertSignUpDate = p.Expert.SignUpDate,
					ExpertProfileImage = p.Expert.ProfileImage,
					ExpertSuggestedPrice = p.SuggestedPrice,
					ExpertEmail = p.Expert.ApplicationUser.Email,
					ExpertPhoneNumber = p.Expert.ApplicationUser.PhoneNumber,
					CustomerId = p.ServiceRequest.CustomerId,
					CustomerFirstName = p.ServiceRequest.Customer.FirstName,
					CustomerLastName = p.ServiceRequest.Customer.LastName,
					CustomerDescription = p.ServiceRequest.CustomerDescription,
					CustomerSignUpDate = p.ServiceRequest.Customer.SignUpDate,
					CustomerProfileImage = p.ServiceRequest.Customer.ProfileImage,
					CustomerSuggestedPrice = p.ServiceRequest.CustomerSuggestedPrice,
					ProposalCreatedAt = p.CreatedAt,
					ServiceRequestCreatedAt = p.ServiceRequest.CreatedAt,
					CustomerEmail = p.ServiceRequest.Customer.ApplicationUser.Email,
					CustomerPhoneNumber = p.ServiceRequest.Customer.ApplicationUser.PhoneNumber,
					ProposalStatus = p.Status,
					ServiceRequestStatus = p.ServiceRequest.Status,
					IsAccepted = p.IsAccepted,
					ServiceRequestId = p.ServiceRequestId,
					ServiceRequestIsDeleted = p.ServiceRequest.IsDeleted,
					ServiceName = p.ServiceRequest.Service.Title,
					CategoryName = p.ServiceRequest.Service.Category.Title
				}).ToListAsync(cancellationToken);

            return proposals;
        }

        public async Task<bool> RejectProposal(int proposalId, CancellationToken cancellationToken)
        {
            var proposal = await _homeServiceDbContext.Proposals
                .FirstOrDefaultAsync(p => p.Id == proposalId, cancellationToken);

            if (proposal is not null)
            {
                proposal.IsAccepted = false;
            }
            else
            {
                throw new Exception($"proposal with id {proposalId} not found!");
            }

            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ChangeProposalStatus(ChangeProposalStatusDto changeProposalStatusDto, CancellationToken cancellationToken)
        {
            Proposal proposal = await GetProposal(changeProposalStatusDto.ProposalId, cancellationToken);
            proposal.Status = changeProposalStatusDto.NewStatus;
            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
            var deletedProposal = await GetProposal(proposalId, cancellationToken);
            deletedProposal.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            var deletedProposalDto = new ProposalSoftDeleteDto()
            {
                Id = deletedProposal.Id,
                IsDeleted = deletedProposal.IsDeleted,
            };
            return deletedProposalDto;
        }

        public async Task<ProposalDto> UpdateProposal(Proposal updatedProposal, CancellationToken cancellationToken)
        {
            var updatingProposal = await GetProposalDto(updatedProposal.Id, cancellationToken);
            updatingProposal.ExpertDescription = updatedProposal.ExpertDescription;
            updatingProposal.ExpertSuggestedPrice = updatedProposal.SuggestedPrice;
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
                    ExpertSuggestedPrice = a.SuggestedPrice
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

        private async Task<Domain.Core.Expert.Entities.Proposal> GetProposal(int proposalId, CancellationToken cancellationToken)
        {
            try
            {
                var proposal = await _homeServiceDbContext.Proposals
                .FirstOrDefaultAsync(a => a.Id == proposalId, cancellationToken);

                if (proposal != null)
                    return proposal;
                throw new Exception($"proposal with id {proposalId} not found.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<List<Proposal>> GetProposalsByServiceRequestId(int serviceRequestId, CancellationToken cancellationToken)
        {
            try
            {
                var proposals = await _homeServiceDbContext.Proposals
                .Where(p => p.ServiceRequestId == serviceRequestId && (p.IsAccepted == null || p.IsAccepted == false))
                .ToListAsync(cancellationToken);

                return proposals;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
