using App.Domain.Core.Admin.Entities.Configs;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Dapper.Customer
{
    public class CityRepoDapper : ICityRepository
    {
        private readonly SiteSettings _siteSettings;
        private readonly IMemoryCache _memoryCache;

        public CityRepoDapper(SiteSettings siteSettings,
            IMemoryCache memoryCache)
        {
            _siteSettings = siteSettings;
            _memoryCache = memoryCache;
        }

        public Task<City> CreateCity(City submittedCity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CityDto>> GetCities(CancellationToken cancellationToken)
        {
            var cities = _memoryCache.Get<List<CityDto>>("Cities");
            if (cities is null)
            {
                using (IDbConnection db = new SqlConnection(_siteSettings.SqlConfiguration.ConnectionsString))
                {
                    cities = (List<CityDto>)await db.QueryAsync<CityDto>("SELECT * FROM Cities");
                    _memoryCache.Set("Cities", cities, new MemoryCacheEntryOptions
                    {
                        SlidingExpiration = TimeSpan.FromDays(30)
                    });
                    return cities;
                }
            }
            return cities;
        }

        public Task<CityDto> GetCityById(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> UpdateCity(City updatedCity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
