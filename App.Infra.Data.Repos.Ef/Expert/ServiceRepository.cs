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
    public class ServiceRepository : IServiceRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ServiceRepository> _logger;
        #endregion

        #region Ctors
        public ServiceRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ServiceRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Service> CreateService(Service createdService, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Services.AddAsync(createdService, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("serviceDtos");

            _logger.LogInformation("ServiceRepository has been successfully added to the database.");
            return createdService;
        }

        public async Task<ServiceDto> GetServiceById(int serviceId, CancellationToken cancellationToken)
        {
            var service = _memoryCache.Get<ServiceDto>("serviceDto");
            if (service is null)
            {
                service = await _homeServiceDbContext.Services
                .Select(a => new Domain.Core.Expert.DTOs.ServiceDto
                {
                    Id = a.Id,
                    Description = a.Description,
                    Title = a.Title,
                }).FirstOrDefaultAsync(a => a.Id == serviceId, cancellationToken);

                if (service != null)
                {
                    _memoryCache.Set("serviceDto", service, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("ServiceDto returned from database, and cached in memory successfully.");
                    return service;
                }
                else
                {
                    _logger.LogError("We expected the ServiceDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("ServiceDto returned from InMemoryCache.");
            return service;
        }

        public async Task<List<ServiceDto>> GetServices(CancellationToken cancellationToken)
        {
            var services = _memoryCache.Get<List<ServiceDto>>("serviceDtos");

            if (services is null)
            {
                services = await _homeServiceDbContext.Services
                .Select(a => new ServiceDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    IsDeleted = a.IsDeleted,
                }).ToListAsync(cancellationToken);

                if (services is null)
                {
                    _logger.LogError("We expected the serviceDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("serviceDtos", services, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceDtos returned from database, and cached in memory successfully.");
                    return services;
                }
            }
            _logger.LogInformation("serviceDtos returned from InMemoryCache.");
            return services;
        }
        //{
        //    var services = await _homeServiceDbContext.Services.ToListAsync(cancellationToken);
        //    if (services != null)
        //    {
        //        return services;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        //public async Task<Service> HardDeleteService(int serviceId, CancellationToken cancellationToken)
        //{
        //    var deletedService = await GetService(serviceId, cancellationToken);
        //    if (deletedService != null)
        //    {
        //        deletedService.IsDeleted = true;
        //        _homeServiceDbContext.Services.Remove(deletedService);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedService;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<ServiceSoftDeleteDto> SoftDeleteService(int serviceId, CancellationToken cancellationToken)
        {
            var deletedService = await GetServiceSoftDeleteDto(serviceId, cancellationToken);
            deletedService.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("serviceDtos");

            var deletedServiceDto = new ServiceSoftDeleteDto();
            deletedServiceDto.Id = deletedService.Id;
            deletedServiceDto.IsDeleted = deletedService.IsDeleted;

            return deletedServiceDto;
        }

        public async Task<ServiceDto> UpdateService(Service updatedService, CancellationToken cancellationToken)
        {
            var updatingService = await GetServiceDto(updatedService.Id, cancellationToken);
            updatingService.Title = updatedService.Title;
            updatingService.Description = updatedService.Description;
            updatingService.Image = updatedService.Image;
            updatingService.WorkExperience = updatedService.WorkExperience;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            var updatingServiceDto = new ServiceDto();
            updatingServiceDto.Title = updatingService.Title;
            updatingServiceDto.Description = updatingService.Description;
            updatingServiceDto.Image = updatingService.Image;

            return updatingServiceDto;
        }
        #endregion

        #region PrivateFields
        private async Task<Domain.Core.Expert.Entities.Service> GetServiceDto(int serviceId, CancellationToken cancellationToken)
        {
            var service = _memoryCache.Get<Service>("serviceDto");
            if (service is null)
            {
                service = await _homeServiceDbContext.Services
                .FirstOrDefaultAsync(a => a.Id == serviceId, cancellationToken);

                if (service != null)
                {
                    _memoryCache.Set("serviceDto", service, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceDto has been returned form database and cached in memory successfully.");
                    return service;
                }
                _logger.LogError($"service with id {serviceId} not found in GetServiceDto method.");
                throw new Exception($"service with id {serviceId} not found.");
            }
            _logger.LogInformation("serviceDto returned from InMemeoryCache in GetServiceDto method.");
            return service;

        }

        private async Task<Domain.Core.Expert.Entities.Service> GetServiceSoftDeleteDto(int serviceId, CancellationToken cancellationToken)
        {
            var service = _memoryCache.Get<Service>("serviceSoftDeleteDto");
            if (service is null)
            {
                service = await _homeServiceDbContext.Services
                    .FirstOrDefaultAsync(a => a.Id == serviceId, cancellationToken);

                if (service != null)
                {
                    _memoryCache.Set("serviceSoftDeleteDto", service, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("serviceSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return service;
                }
                _logger.LogError($"service with id {serviceId} not found in GetServiceSoftDeleteDto method.");
                throw new Exception($"service with id {serviceId} not found.");
            }
            _logger.LogInformation("serviceSoftDeleteDto returned from InMemeoryCache in GetServiceSoftDeleteDto method.");
            return service;

        }
        #endregion
    }
}
