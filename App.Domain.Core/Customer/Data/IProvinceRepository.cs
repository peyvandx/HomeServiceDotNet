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
        public Task<Customer.Entities.Province> UpdateProvince(Customer.Entities.Province updatedProvince, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Province> GetProvinceById(int provinceId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Province>> GetProvinces(CancellationToken cancellationToken);
    }
}
