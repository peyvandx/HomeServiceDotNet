using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class ServiceRequestRepository : IServiceRequestRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ServiceRequestRepository> _logger;
        private readonly IProposalRepository _proposalRepository;
        #endregion

        #region Ctors
        public ServiceRequestRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ServiceRequestRepository> logger,
            IProposalRepository proposalRepository)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
            _proposalRepository = proposalRepository;
        }

        #endregion

        #region Implementations
        public async Task<ServiceRequest> CreateServiceRequest(ServiceRequest submittedServiceRequest, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.ServiceRequests.AddAsync(submittedServiceRequest, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("{ServiceRequest} has been successfully added to the database.", submittedServiceRequest);
            return submittedServiceRequest;
        }

        public async Task<ServiceRequestDto> GetServiceRequestById(int serviceRequestId, CancellationToken cancellationToken)
        {
            
                var serviceRequest = await _homeServiceDbContext.ServiceRequests
                .Select(sr => new ServiceRequestDto
                {
                    Id = sr.Id,
                    CustomerDescription = sr.CustomerDescription,
                    Status = sr.Status,
                    Price = sr.CustomerSuggestedPrice,
                    IsDone = sr.IsDone,
                }).FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);

                if (serviceRequest != null)
                    return serviceRequest;
                else
                {
                    _logger.LogError("We expected the serviceRequestDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
        }

        public async Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken)
        {
            var serviceRequests = _memoryCache.Get<List<ServiceRequestDto>>("serviceRequestDtos");

            if (serviceRequests is null)
            {
                serviceRequests = await _homeServiceDbContext.ServiceRequests
                .Select(sr => new ServiceRequestDto()
                {
                    Id = sr.Id,
                    CustomerDescription = sr.CustomerDescription,
                    Status = sr.Status,
                    Price = sr.CustomerSuggestedPrice,
                    IsDone = sr.IsDone,
                    IsDeleted = sr.IsDeleted,
                }).ToListAsync(cancellationToken);

                if (serviceRequests is null)
                {
                    _logger.LogError("We expected the serviceRequestDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("serviceRequestDtos", serviceRequests, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceRequestDtos returned from database, and cached in memory successfully.");
                    return serviceRequests;
                }
            }
            _logger.LogInformation("serviceRequestDtos returned from InMemoryCache.");
            return serviceRequests;
        }
        //{
        //    var serviceRequests = _homeServiceDbContext.ServiceRequests.ToListAsync();
        //    if (serviceRequests != null)
        //    {
        //        return serviceRequests;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        //public async Task<ServiceRequest> HardDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        //{
        //    var deletedServiceRequest = await GetServiceRequest(serviceRequestId, cancellationToken);
        //    if (deletedServiceRequest != null)
        //    {
        //        deletedServiceRequest.IsDeleted = true;
        //        _homeServiceDbContext.ServiceRequests.Remove(deletedServiceRequest);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedServiceRequest;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<ServiceRequestSoftDeleteDto> SoftDeleteServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        {
            var deletedServiceRequest = await GetServiceRequestSoftDeleteDto(serviceRequestId, cancellationToken);
            deletedServiceRequest.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("serviceRequestDtos");

            var deletedServiceRequestDto = new ServiceRequestSoftDeleteDto();
            deletedServiceRequestDto.Id = deletedServiceRequest.Id;
            deletedServiceRequestDto.IsDeleted = deletedServiceRequest.IsDeleted;

            return deletedServiceRequestDto;
        }

        public async Task<ServiceRequestDto> UpdateServiceRequest(ServiceRequest updatedServiceRequest, CancellationToken cancellationToken)
        {
            var updatingServiceRequest = await GetServiceRequest(updatedServiceRequest.Id, cancellationToken);
            updatingServiceRequest.CustomerDescription = updatedServiceRequest.CustomerDescription;
            updatingServiceRequest.CustomerSuggestedPrice = updatedServiceRequest.CustomerSuggestedPrice;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            var updatedServiceRequestDto = new ServiceRequestDto();
            updatedServiceRequestDto.Id = updatingServiceRequest.Id;
            updatedServiceRequestDto.CustomerDescription = updatingServiceRequest.CustomerDescription;
            updatedServiceRequestDto.Price = updatingServiceRequest.CustomerSuggestedPrice;

            _memoryCache.Remove("serviceRequestDtos");

            return updatedServiceRequestDto;
        }

        public async Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken)
        {
            try
            {
                ServiceRequest serviceRequest = await GetServiceRequest(newStatus.ServiceRequestId, cancellationToken);
                serviceRequest.Status = newStatus.NewStatus;
                if (newStatus.NewStatus == ServiceRequestStatus.Success)
                    serviceRequest.ExpertId = newStatus.ExpertId;

                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                _memoryCache.Remove("serviceRequestDtos");
                return newStatus;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<List<ServiceRequestDto>> GetCustomerServiceRequests(int? customerId, CancellationToken cancellationToken)
        {
            var customerServiceRequests = await _homeServiceDbContext.ServiceRequests
                .Where(x => x.CustomerId == customerId && x.IsDeleted == false)
                .Include(x => x.Service)
                .Select(x => new ServiceRequestDto()
                {
                    Id = x.Id,
                    CustomerDescription = x.CustomerDescription,
                    Price = x.CustomerSuggestedPrice,
                    IsDone = x.IsDone,
                    IsDeleted = x.IsDeleted,
                    Status = x.Status,
                    ServiceId = x.ServiceId,
                    ServiceName = x.Service.Title,
                    ServiceImageUrl = x.Service.Image
                }).ToListAsync(cancellationToken);

            return customerServiceRequests;
        }

        public async Task<List<ServiceRequestDto>> GetExpertRelatedServiceRequests(int expertId, CancellationToken cancellationToken)
        {
            var expertServiceIds = await GetExpertServiceIds(expertId, cancellationToken);
            var expertProposalsServiceIds = await _proposalRepository.GetExpetProposalsServiceRequestIds(expertId, cancellationToken);
            var expertRelatedRequests = new List<ServiceRequestDto>();

            foreach (var expertServiceId in expertServiceIds.ServiceIds)
            {
                var serviceRequestDto = await _homeServiceDbContext.ServiceRequests
                .Where(x => (x.Status == ServiceRequestStatus.WaitingForAcceptAProposal || x.Status == ServiceRequestStatus.WaitingForExpertsProposals) && x.ServiceId == expertServiceId && x.IsDeleted == false && !expertProposalsServiceIds.Contains(x.Id))
                .Include(x => x.Service)
                .Select(x => new ServiceRequestDto()
                {
                    Id = x.Id,
                    CustomerDescription = x.CustomerDescription,
                    Price = x.CustomerSuggestedPrice,
                    IsDone = x.IsDone,
                    IsDeleted = x.IsDeleted,
                    Status = x.Status,
                    ServiceId = x.ServiceId,
                    ServiceName = x.Service.Title,
                    ServiceImageUrl = x.Service.Image,
                }).ToListAsync(cancellationToken);

                expertRelatedRequests.AddRange(serviceRequestDto);
            }

            return expertRelatedRequests;
        }

        #endregion

        #region PrivateMethods
        private async Task<ServiceRequest> GetServiceRequest(int serviceRequestId, CancellationToken cancellationToken)
        {
            //var serviceRequest = _memoryCache.Get<ServiceRequest>("serviceRequestDto");
            var serviceRequest = new ServiceRequest();
            //if (serviceRequest is null)
            //{
            serviceRequest = await _homeServiceDbContext.ServiceRequests
            .FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);

            if (serviceRequest != null)
            {
                //_memoryCache.Set("serviceRequestDto", serviceRequest, new MemoryCacheEntryOptions()
                //{
                //    SlidingExpiration = TimeSpan.FromSeconds(120)
                //});
                _logger.LogInformation("serviceRequestDto has been returned form database and cached in memory successfully.");
                return serviceRequest;
            }
            _logger.LogError($"serviceRequest with id {serviceRequestId} not found in GetServiceRequestDto method.");
            throw new Exception($"serviceRequest with id {serviceRequestId} not found.");
            //}
            //_logger.LogInformation("serviceRequestDto returned from InMemeoryCache in GetServiceRequestDto method.");
            //return serviceRequest;
        }

        private async Task<ServiceRequest> GetServiceRequestSoftDeleteDto(int serviceRequestId, CancellationToken cancellationToken)
        {
            var serviceRequest = await _homeServiceDbContext.ServiceRequests
            .FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);

            if (serviceRequest != null)
                return serviceRequest;
            _logger.LogError($"serviceRequest with id {serviceRequestId} not found in GetServiceRequestSoftDeleteDto method.");
            throw new Exception($"serviceRequest with id {serviceRequestId} not found.");
        }

        private async Task<ExpertServiceIdsDto> GetExpertServiceIds(int expertId, CancellationToken cancellationToken)
        {
            var expertServiceIds = await _homeServiceDbContext.Experts
                .Select(e => new ExpertServiceIdsDto
                {
                    Id = e.Id,
                    ServiceIds = e.Services.Select(s => s.Id).ToList()
                }).FirstOrDefaultAsync(e => e.Id == expertId, cancellationToken);

            if (expertServiceIds is null)
                throw new Exception("Expert Does Not Have Any Services");
            else
                return expertServiceIds;
        }

        #endregion
    }
}
