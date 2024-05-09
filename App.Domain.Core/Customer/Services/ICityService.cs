using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Services
{
    public interface ICityService
    {
        public Task<Customer.Entities.City> CreateCity(CityDto cityDto, CancellationToken cancellationToken);
        public Task<DTOs.CityDto> UpdateCity(CityDto cityDto, CancellationToken cancellationToken);
        public Task<DTOs.CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.City> HardDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<DTOs.CityDto> GetCityById(int cityId, CancellationToken cancellationToken);
        public Task<List<DTOs.CityDto>> GetCities(CancellationToken cancellationToken);
    }
}
