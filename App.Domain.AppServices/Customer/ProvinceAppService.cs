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
    public class ProvinceAppService : IProvinceAppService
    {
        #region Fields
        private readonly IProvinceService _provinceService;
        #endregion

        #region Ctors
        public ProvinceAppService(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        #endregion

        #region Implementations
        public Task<Province> CreateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
            => _provinceService.CreateProvince(provinceDto, cancellationToken);

        public Task<ProvinceDto> GetProvinceById(int provinceId, CancellationToken cancellationToken)
            => _provinceService.GetProvinceById(provinceId, cancellationToken);

        public Task<List<ProvinceDto>> GetProvinces(CancellationToken cancellationToken)
            => _provinceService.GetProvinces(cancellationToken);

        //public Task<Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken)
        //    => _provinceService.HardDeleteProvince(provinceId, cancellationToken);

        public Task<ProvinceSoftDeleteDto> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken)
            => _provinceService.SoftDeleteProvince(provinceId, cancellationToken);

        public Task<ProvinceDto> UpdateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
            => _provinceService.UpdateProvince(provinceDto, cancellationToken);
        #endregion
    }
}
