using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
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
        #endregion

        #region Ctors
        public ServiceRequestRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ServiceRequestRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
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
            var serviceRequest = _memoryCache.Get<ServiceRequestDto?>("serviceRequestDto");
            if (serviceRequest is null)
            {
                serviceRequest = await _homeServiceDbContext.ServiceRequests
                .Select(sr => new ServiceRequestDto
                {
                    Id = sr.Id,
                    CustomerDescription = sr.CustomerDescription,
                    Status = sr.Status,
                    Price = sr.Price,
                    IsDone = sr.IsDone,
                }).FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);

                if (serviceRequest != null)
                {
                    _memoryCache.Set("serviceRequestDto", serviceRequest, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceRequestDto returned from database, and cached in memory successfully.");
                    return serviceRequest;
                }
                else
                {
                    _logger.LogError("We expected the serviceRequestDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("serviceRequestDto returned from InMemoryCache.");
            return serviceRequest;
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
                    Price = sr.Price,
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
            var updatingServiceRequest = await GetServiceRequestDto(updatedServiceRequest.Id, cancellationToken);
            updatingServiceRequest.CustomerDescription = updatedServiceRequest.CustomerDescription;
            updatingServiceRequest.Price = updatedServiceRequest.Price;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            var updatedServiceRequestDto = new ServiceRequestDto();
            updatedServiceRequestDto.Id = updatingServiceRequest.Id;
            updatedServiceRequestDto.CustomerDescription = updatingServiceRequest.CustomerDescription;
            updatedServiceRequestDto.Price = updatingServiceRequest.Price;

            return updatedServiceRequestDto;
        }

        public async Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken)
        {
            var serviceRequest = await GetServiceRequestDto(newStatus.ServiceRequestId, cancellationToken);
            serviceRequest.Status = newStatus.NewStatus;
            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                _memoryCache.Remove("serviceRequestDtos");
                return newStatus;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<ServiceRequest> GetServiceRequestDto(int serviceRequestId, CancellationToken cancellationToken)
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
            var serviceRequest = _memoryCache.Get<ServiceRequest>("serviceRequestSoftDeleteDto");
            if (serviceRequest is null)
            {
                serviceRequest = await _homeServiceDbContext.ServiceRequests
                .FirstOrDefaultAsync(sr => sr.Id == serviceRequestId, cancellationToken);

                if (serviceRequest != null)
                {
                    _memoryCache.Set("serviceRequestSoftDeleteDto", serviceRequest, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceRequestSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return serviceRequest;
                }
                _logger.LogError($"serviceRequest with id {serviceRequestId} not found in GetServiceRequestSoftDeleteDto method.");
                throw new Exception($"serviceRequest with id {serviceRequestId} not found.");
            }
            _logger.LogInformation("serviceRequestSoftDeleteDto returned from InMemeoryCache in GetServiceRequestSoftDeleteDto method.");
            return serviceRequest;

        }
        #endregion
    }
}
