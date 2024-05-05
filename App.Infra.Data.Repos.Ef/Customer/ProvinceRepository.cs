using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class ProvinceRepository : IProvinceRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public ProvinceRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Province> CreateProvince(Province submittedProvince, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Provinces.AddAsync(submittedProvince, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedProvince;
        }

        public async Task<Province> GetProvinceById(int provinceId, CancellationToken cancellationToken)
        {
            var province = await _homeServiceDbContext.Provinces.FirstOrDefaultAsync(p => p.Id == provinceId, cancellationToken);
            if (province != null)
            {
                return province;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Province>> GetProvinces(CancellationToken cancellationToken) => await _homeServiceDbContext.Provinces.ToListAsync(cancellationToken);
        //{
        //    var provinces = _homeServiceDbContext.Provinces.ToList();
        //    if (provinces != null)
        //    {
        //        return provinces;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Province> HardDeleteProvince(int provinceId, CancellationToken cancellationToken)
        {
            var deletedProvince = await GetProvince(provinceId, cancellationToken);
            if (deletedProvince != null)
            {
                deletedProvince.IsDeleted = true;
                _homeServiceDbContext.Provinces.Remove(deletedProvince);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Province> SoftDeleteProvince(int provinceId, CancellationToken cancellationToken)
        {
            var deletedProvince = await GetProvince(provinceId, cancellationToken);
            if (deletedProvince != null)
            {
                deletedProvince.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Province> UpdateProvince(Province updatedProvince, CancellationToken cancellationToken)
        {
            var updatingProvince = await GetProvince(updatedProvince.Id, cancellationToken);
            if (updatingProvince != null)
            {
                updatingProvince.Name = updatedProvince.Name;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.Province> GetProvince(int provinceId, CancellationToken cancellationToken)
        {
            var province = await _homeServiceDbContext.Provinces
                .FirstOrDefaultAsync(a => a.Id == provinceId, cancellationToken);

            if (province != null)
            {
                return province;
            }

            throw new Exception($"admin with id {provinceId} not found");
        }
        #endregion
    }
}
