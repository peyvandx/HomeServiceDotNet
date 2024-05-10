using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class CityAppService : ICityAppService
    {
        #region Fields
        private readonly ICityService _cityService;
        #endregion

        #region Ctors
        public CityAppService(ICityService cityService)
        {
            _cityService = cityService;
        }
        #endregion

        #region Implementations
        public Task<City> CreateCity(CityDto cityDto, CancellationToken cancellationToken)
            => _cityService.CreateCity(cityDto, cancellationToken);

        public Task<List<CityDto>> GetCities(CancellationToken cancellationToken)
            => _cityService.GetCities(cancellationToken);

        public Task<CityDto> GetCityById(int cityId, CancellationToken cancellationToken)
            => _cityService.GetCityById(cityId, cancellationToken);

        //public Task<City> HardDeleteCity(int cityId, CancellationToken cancellationToken)
        //    => _cityService.HardDeleteCity(cityId, cancellationToken);

        public Task<CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
            => _cityService.SoftDeleteCity(cityId, cancellationToken);

        public Task<CityDto> UpdateCity(CityDto cityDto, CancellationToken cancellationToken)
            => _cityService.UpdateCity(cityDto, cancellationToken);
        #endregion
    }
}
