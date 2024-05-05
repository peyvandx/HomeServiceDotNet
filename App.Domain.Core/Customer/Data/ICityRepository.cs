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
        public Task<Customer.Entities.City> UpdateCity(Customer.Entities.City updatedCity, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> SoftDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> HardDeleteCity(int cityId, CancellationToken cancellationToken);
        public Task<Customer.Entities.City> GetCityById(int cityId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.City>> GetCities(CancellationToken cancellationToken);
    }
}
