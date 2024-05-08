using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.AppServices
{
    public interface IProvinceAppService
    {
        public Task<Customer.Entities.Province> CreateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> UpdateProvince(ProvinceDto provinceDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> GetProvinceById(int provinceId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Province>> GetProvinces(CancellationToken cancellationToken);
    }
}
