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
    public class ProvinceAppService : IProvinceAppService
    {
        public Task<Province> CreateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Province> GetProvinceById(int provinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Province>> GetProvinces(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Province> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Province> UpdateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
