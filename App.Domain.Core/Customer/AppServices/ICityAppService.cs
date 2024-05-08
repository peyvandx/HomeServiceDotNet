using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.AppServices
{
    public interface ICityAppService
    {
        public Task<Customer.Entities.City> CreateCity(CityDto cityDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> UpdateCity(CityDto cityDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> SoftDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> HardDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> GetCityById(int cityId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.City>> GetCities(CancellationToken cancellationToken);
    }
}
