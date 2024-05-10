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
    public class ProvinceService : IProvinceService
    {
        #region Fields
        private readonly IProvinceRepository _provinceRepository;
        #endregion

        #region Ctors
        public ProvinceService(IProvinceRepository provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }
        #endregion

        #region Implementations
        public async Task<Province> CreateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
        {
            var creatingProvince = new Province();
            creatingProvince.CreatedAt = DateTime.Now;
            creatingProvince.Name = provinceDto.Name;
            return await _provinceRepository.CreateProvince(creatingProvince, cancellationToken);
        }


        public async Task<List<ProvinceDto>> GetProvinces(CancellationToken cancellationToken)
            => await _provinceRepository.GetProvinces(cancellationToken);


        public async Task<ProvinceDto> GetProvinceById(int provinceId, CancellationToken cancellationToken)
            => await _provinceRepository.GetProvinceById(provinceId, cancellationToken);


        //public async Task<Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken)
        //    => await _provinceRepository.HardDeleteProvince(provinceId, cancellationToken);


        public async Task<ProvinceSoftDeleteDto> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken)
            => await _provinceRepository.SoftDeleteProvince(provinceId, cancellationToken);


        public async Task<ProvinceDto> UpdateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
        {
            var updatedProvince = new Province();
            updatedProvince.Name = provinceDto.Name;
            return await _provinceRepository.UpdateProvince(updatedProvince, cancellationToken);
        }

        #endregion
    }
}
