using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class CityService : ICityService
    {
        #region Fileds
        private readonly ICityRepository _cityRepository;
        #endregion

        #region Ctors
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        #endregion

        #region Implementations
        public async Task<City> CreateCity(CityDto cityDto, CancellationToken cancellationToken)
        {
            var creatingCity = new City();
            creatingCity.CreatedAt = DateTime.Now;
            creatingCity.Name = cityDto.Name;
            //creatingCity.ProvinceId = cityDto.ProvinceId;
            return await _cityRepository.CreateCity(creatingCity, cancellationToken);
        }


        public async Task<CityDto> GetCityById(int cityId, CancellationToken cancellationToken)
            => await _cityRepository.GetCityById(cityId, cancellationToken);


        public async Task<List<CityDto>> GetCities(CancellationToken cancellationToken)
            => await _cityRepository.GetCities(cancellationToken);


        //public async Task<City> HardDeleteCity(int cityId, CancellationToken cancellationToken)
        //    => await _cityRepository.HardDeleteCity(cityId, cancellationToken);


        public async Task<CitySoftDeleteDto> SoftDeleteCity(int cityId, CancellationToken cancellationToken)
            => await _cityRepository.SoftDeleteCity(cityId, cancellationToken);


        public async Task<CityDto> UpdateCity(CityDto cityDto, CancellationToken cancellationToken)
        {
            var updatedCity = new City();
            updatedCity.Name = cityDto.Name;
            //updatedCity.ProvinceId = cityDto.ProvinceId;
            return await _cityRepository.UpdateCity(updatedCity, cancellationToken);
        }

        #endregion
    }
}
