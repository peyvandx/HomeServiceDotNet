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
        public Task<CityDto> UpdateCity(CityDto cityDto, CancellationToken cancellationToken);
        public Task<CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.City> HardDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<CityDto> GetCityById(int cityId, CancellationToken cancellationToken);
        public Task<List<CityDto>> GetCities(CancellationToken cancellationToken);
    }
}
