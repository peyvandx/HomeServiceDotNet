using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CityRepository : ICityRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public CityRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<City> CreateCity(City submittedCity, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Cities.AddAsync(submittedCity, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedCity;
        }

        public async Task<List<City>> GetCities(CancellationToken cancellationToken) => await _homeServiceDbContext.Cities.ToListAsync(cancellationToken);
        //{
        //    var cities = _homeServiceDbContext.Cities.ToList();
        //    if (cities != null)
        //    {
        //        return cities;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<City> GetCityById(int cityId, CancellationToken cancellationToken)
        {
            var city = await _homeServiceDbContext.Cities.FirstOrDefaultAsync(c => c.Id == cityId, cancellationToken);
            if (city != null)
            {
                return city;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<City> HardDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            var deletedCity = await GetCity(cityId, cancellationToken);
            if (deletedCity != null)
            {
                deletedCity.IsDeleted = true;
                _homeServiceDbContext.Cities.Remove(deletedCity);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<City> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            var deletedCity = await GetCity(cityId, cancellationToken);
            if (deletedCity != null)
            {
                deletedCity.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<City> UpdateCity(City updatedCity, CancellationToken cancellationToken)
        {
            var updatingCity = await GetCity(updatedCity.Id, cancellationToken);
            if (updatingCity != null)
            {
                updatingCity.Name = updatedCity.Name;
                updatingCity.ProvinceId = updatedCity.ProvinceId;
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
        private async Task<Domain.Core.Customer.Entities.City> GetCity(int cityId, CancellationToken cancellationToken)
        {
            var city = await _homeServiceDbContext.Cities
                .FirstOrDefaultAsync(a => a.Id == cityId, cancellationToken);

            if (city != null)
            {
                return city;
            }

            throw new Exception($"city with id {cityId} not found");
        }
        #endregion
    }
}
