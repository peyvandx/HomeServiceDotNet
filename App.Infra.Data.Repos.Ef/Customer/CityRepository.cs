using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CityRepository : ICityRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<AddressRepository> _logger;
        #endregion

        #region Ctors
        public CityRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<AddressRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<City> CreateCity(City submittedCity, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Cities.AddAsync(submittedCity, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("City has been successfully added to the database.");
            return submittedCity;
        }

        public async Task<List<CityDto>> GetCities(CancellationToken cancellationToken)
        {
            var cities = _memoryCache.Get<List<CityDto>>("cityDtos");

            if (cities is null)
            {
                cities = await _homeServiceDbContext.Cities
                .Select(c => new CityDto()
                {
                    Id = c.Id,
                    Name = c.Name,
                    //ProvinceName = c.Province.Name
                }).ToListAsync(cancellationToken);

                if (cities is null)
                {
                    _logger.LogError("We expected the cityDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("cityDtos", cities, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("cityDtos returned from database, and cached in memory successfully.");
                    return cities;
                }
            }
            _logger.LogInformation("cityDtos returned from InMemoryCache.");
            return cities;
        }

        public async Task<CityDto> GetCityById(int cityId, CancellationToken cancellationToken)
        {
            var city = _memoryCache.Get<CityDto?>("cityDto");
            if (city is null)
            {
                city = await _homeServiceDbContext.Cities
                .Select(c => new CityDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    //ProvinceName = c.Province.Name
                }).FirstOrDefaultAsync(c => c.Id == cityId, cancellationToken);

                if (city != null)
                {
                    _memoryCache.Set("cityDto", city, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("cityDto returned from database, and cached in memory successfully.");
                    return city;
                }
                else
                {
                    _logger.LogError("We expected the AdminProfileDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("cityDto returned from InMemoryCache.");
            return city;
        }

        //public async Task<City> HardDeleteCity(int cityId, CancellationToken cancellationToken)
        //{
        //    var deletedCity = await GetCity(cityId, cancellationToken);
        //    if (deletedCity != null)
        //    {
        //        deletedCity.IsDeleted = true;
        //        _homeServiceDbContext.Cities.Remove(deletedCity);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedCity;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            var deletedCity = await GetCitySoftDeleteDto(cityId, cancellationToken);
            
            deletedCity.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("City has been successfully deleted.");
            return deletedCity;
        }

        public async Task<CityDto> UpdateCity(City updatedCity, CancellationToken cancellationToken)
        {
            var updatingCity = await GetCityDto(updatedCity.Id, cancellationToken);
            if (updatingCity != null)
            {
                updatingCity.Name = updatedCity.Name;
                //updatingCity.ProvinceId = updatedCity.ProvinceId;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<CityDto> GetCityDto(int cityId, CancellationToken cancellationToken)
        {
            var city = _memoryCache.Get<CityDto>("cityDto");
            if (city is null)
            {
                city = await _homeServiceDbContext.Cities
                .Select(a => new CityDto()
                {
                    Id = a.Id,
                    //ProvinceId = a.ProvinceId,
                    //ProvinceName = a.Province.Name,
                }).FirstOrDefaultAsync(a => a.Id == cityId, cancellationToken);

                if (city != null)
                {
                    _memoryCache.Set("cityDto", city, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("cityDto has been returned form database and cached in memory successfully.");
                    return city;
                }
                _logger.LogError($"city with id {cityId} not found in GetCityDto method.");
                throw new Exception($"city with id {cityId} not found.");
            }
            _logger.LogInformation("CityDto returned from InMemeoryCache in GetCityDto method.");
            return city;
        }

        private async Task<CitySoftDeleteDto> GetCitySoftDeleteDto(int cityId, CancellationToken cancellationToken)
        {
            var city = _memoryCache.Get<CitySoftDeleteDto>("citySoftDeleteDto");
            if (city is null)
            {
                city = await _homeServiceDbContext.Cities
                .Select(c => new CitySoftDeleteDto()
                {
                    Id = c.Id,
                    IsDeleted = c.IsDeleted
                }).FirstOrDefaultAsync(c => c.Id == cityId, cancellationToken);

                if (city != null)
                {
                    _memoryCache.Set("citySoftDeleteDto", city, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("citySoftDeleteDto has been returned form database and cached in memory successfully.");
                    return city;
                }
                _logger.LogError($"city with id {cityId} not found in GetCitySoftDeleteDto method.");
                throw new Exception($"city with id {cityId} not found.");
            }
            _logger.LogInformation("citySoftDeleteDto returned from InMemeoryCache in GetCitySoftDeleteDto method.");
            return city;

        }
        #endregion
    }
}
