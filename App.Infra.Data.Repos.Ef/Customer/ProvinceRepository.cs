using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class ProvinceRepository : IProvinceRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProvinceRepository> _logger;
        #endregion

        #region Ctors
        public ProvinceRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ProvinceRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Province> CreateProvince(Province submittedProvince, CancellationToken cancellationToken)
        {
            //await _homeServiceDbContext.Provinces.AddAsync(submittedProvince, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Province has been successfully added to the database.");
            return submittedProvince;
        }

        public async Task<ProvinceDto> GetProvinceById(int provinceId, CancellationToken cancellationToken)
        {
            var province = _memoryCache.Get<ProvinceDto>("provinceDto");
            if (province is null)
            {
                //province = await _homeServiceDbContext.Provinces
                //.Select(p => new ProvinceDto
                //{
                //    Id = p.Id,
                //    Name = p.Name,
                //}).FirstOrDefaultAsync(p => p.Id == provinceId, cancellationToken);

                if (province != null)
                {
                    _memoryCache.Set("provinceDto", province, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("provinceDto returned from database, and cached in memory successfully.");
                    return province;
                }
                else
                {
                    _logger.LogError("We expected the provinceDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("provinceDto returned from InMemoryCache.");
            return province;
        }

        public async Task<List<ProvinceDto>> GetProvinces(CancellationToken cancellationToken)
        {
            var provinces = _memoryCache.Get<List<ProvinceDto>>("provinceDtos");

            if (provinces is null)
            {
                //provinces = await _homeServiceDbContext.Provinces
                //.Select(p => new ProvinceDto()
                //{
                //    Id = p.Id,
                //    Name = p.Name,
                //}).ToListAsync(cancellationToken);

                if (provinces is null)
                {
                    _logger.LogError("We expected the provinceDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("provinceDtos", provinces, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("provinceDtos returned from database, and cached in memory successfully.");
                    return provinces;
                }
            }
            _logger.LogInformation("provinceDtos returned from InMemoryCache.");
            return provinces;
        }
        //{
        //    var provinces = _homeServiceDbContext.Provinces.ToList();
        //    if (provinces != null)
        //    {
        //        return provinces;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        //public async Task<Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken)
        //{
        //    var deletedProvince = await GetProvince(provinceId, cancellationToken);
        //    if (deletedProvince != null)
        //    {
        //        deletedProvince.IsDeleted = true;
        //        _homeServiceDbContext.Provinces.Remove(deletedProvince);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedProvince;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<ProvinceSoftDeleteDto> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken)
        {
            var deletedProvince = await GetProvicneSoftDeleteDto(provinceId, cancellationToken);
            deletedProvince.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedProvince;
        }

        public async Task<ProvinceDto> UpdateProvince(Province updatedProvince, CancellationToken cancellationToken)
        {
            //var updatingProvince = await GetProvinceDto(updatedProvince.Id, cancellationToken);
            //updatingProvince.Name = updatedProvince.Name;
            //await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            //return updatingProvince;
            var updatingProvince = new ProvinceDto();
            return updatingProvince;
        }
        #endregion

        #region PrivateMethods
        private async Task<ProvinceDto> GetProvinceDto(int provinceId, CancellationToken cancellationToken)
        {
            var province = _memoryCache.Get<ProvinceDto>("provinceDto");
            if (province is null)
            {
                //province = await _homeServiceDbContext.Provinces
                //.Select(p => new ProvinceDto()
                //{
                //    Id = p.Id,
                //    Name = p.Name,
                //}).FirstOrDefaultAsync(p => p.Id == provinceId, cancellationToken);

                if (province != null)
                {
                    _memoryCache.Set("provinceDto", province, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("provinceDto has been returned form database and cached in memory successfully.");
                    return province;
                }
                _logger.LogError($"province with id {provinceId} not found in GetProvinceDto method.");
                throw new Exception($"province with id {provinceId} not found.");
            }
            _logger.LogInformation("provinceDto returned from InMemeoryCache in GetProvinceDto method.");
            return province;
        }

        private async Task<ProvinceSoftDeleteDto> GetProvicneSoftDeleteDto(int provinceId, CancellationToken cancellationToken)
        {
            var province = _memoryCache.Get<ProvinceSoftDeleteDto>("provinceSoftDeleteDto");
            if (province is null)
            {
                //province = await _homeServiceDbContext.Provinces
                //.Select(p => new ProvinceSoftDeleteDto()
                //{
                //    Id = p.Id,
                //    IsDeleted = p.IsDeleted
                //}).FirstOrDefaultAsync(p => p.Id == provinceId, cancellationToken);

                if (province != null)
                {
                    _memoryCache.Set("provinceSoftDeleteDto", province, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("provinceSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return province;
                }
                _logger.LogError($"province with id {provinceId} not found in GetAdminSoftDeleteDto method.");
                throw new Exception($"province with id {provinceId} not found.");
            }
            _logger.LogInformation("provinceSoftDeleteDto returned from InMemeoryCache in GetAdminSoftDeleteDto method.");
            return province;

        }
        #endregion
    }
}
