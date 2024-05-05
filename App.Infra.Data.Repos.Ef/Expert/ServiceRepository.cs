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
    public class ServiceRepository : IServiceRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public ServiceRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Service> CreateService(Service createdService, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Services.AddAsync(createdService, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return createdService;
        }

        public async Task<Service> GetServiceById(int serviceId, CancellationToken cancellationToken)
        {
            var service = await _homeServiceDbContext.Services.FirstOrDefaultAsync(s => s.Id == serviceId, cancellationToken);
            if (service != null)
            {
                return service;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Service>> GetServices(CancellationToken cancellationToken) => await _homeServiceDbContext.Services.ToListAsync(cancellationToken);
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

        public async Task<Service> HardDeleteService(int serviceId, CancellationToken cancellationToken)
        {
            var deletedService = await GetService(serviceId, cancellationToken);
            if (deletedService != null)
            {
                deletedService.IsDeleted = true;
                _homeServiceDbContext.Services.Remove(deletedService);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Service> SoftDeleteService(int serviceId, CancellationToken cancellationToken)
        {
            var deletedService = await GetService(serviceId, cancellationToken);
            if (deletedService != null)
            {
                deletedService.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Service> UpdateService(Service updatedService, CancellationToken cancellationToken)
        {
            var updatingService = await GetService(updatedService.Id, cancellationToken);
            if (updatingService != null)
            {
                updatingService.Title = updatedService.Title;
                updatingService.Description = updatedService.Description;
                updatingService.Image = updatedService.Image;
                updatingService.WorkExperience = updatedService.WorkExperience;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateFields
        private async Task<Domain.Core.Expert.Entities.Service> GetService(int serviceId, CancellationToken cancellationToken)
        {
            var service = await _homeServiceDbContext.Services
                .FirstOrDefaultAsync(a => a.Id == serviceId, cancellationToken);

            if (service != null)
            {
                return service;
            }

            throw new Exception($"admin with id {serviceId} not found");
        }
        #endregion
    }
}
