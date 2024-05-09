using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface ICityRepository
    {
        public Task<Customer.Entities.City> CreateCity(Customer.Entities.City submittedCity, CancellationToken cancellationToken);
        public Task<Customer.DTOs.CityDto> UpdateCity(Customer.Entities.City updatedCity, CancellationToken cancellationToken);
        public Task<Customer.DTOs.CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.City> HardDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<Customer.DTOs.CityDto> GetCityById(int cityId, CancellationToken cancellationToken);
        public Task<List<Customer.DTOs.CityDto>> GetCities(CancellationToken cancellationToken);
    }
}
