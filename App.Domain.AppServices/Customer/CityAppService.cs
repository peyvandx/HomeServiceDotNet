using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class CityAppService : ICityAppService
    {
        public Task<City> CreateCity(CityDto cityDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetCities(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetCityById(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<City> HardDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<City> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<City> UpdateCity(CityDto cityDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
