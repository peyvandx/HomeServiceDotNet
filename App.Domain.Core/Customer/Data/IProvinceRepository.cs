using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface IProvinceRepository
    {
        public Task<Customer.Entities.Province> CreateProvince(Customer.Entities.Province submittedProvince, CancellationToken cancellationToken);
        public Task<ProvinceDto> UpdateProvince(Customer.Entities.Province updatedProvince, CancellationToken cancellationToken);
        public Task<ProvinceSoftDeleteDto> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken);
        public Task<ProvinceDto> GetProvinceById(int provinceId, CancellationToken cancellationToken);
        public Task<List<ProvinceDto>> GetProvinces(CancellationToken cancellationToken);
    }
}
