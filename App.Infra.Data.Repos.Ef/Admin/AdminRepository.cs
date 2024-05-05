using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.DTOs;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Admin
{
    public class AdminRepository : IAdminRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public AdminRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Domain.Core.Admin.Entities.Admin> CreateAdmin(Domain.Core.Admin.Entities.Admin signingUpAdmin, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Admins.AddAsync(signingUpAdmin, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return signingUpAdmin;
        }

        public async Task<Domain.Core.Admin.Entities.Admin> GetAdminById(int adminId, CancellationToken cancellationToken)
        {
            var admin = await _homeServiceDbContext.Admins.FirstOrDefaultAsync(a => a.Id == adminId, cancellationToken);
            if (admin != null)
            {
                return admin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Domain.Core.Admin.Entities.Admin>> GetAdmins(CancellationToken cancellationToken) => await _homeServiceDbContext.Admins.ToListAsync(cancellationToken);

        public async Task<Domain.Core.Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken)
        {
            var deletedAdmin = await GetAdmin(adminId, cancellationToken);
            if (deletedAdmin != null)
            {
                deletedAdmin.IsDeleted = true;
                _homeServiceDbContext.Admins.Remove(deletedAdmin);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedAdmin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Domain.Core.Admin.Entities.Admin> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken)
        {
            var deletedAdmin = await GetAdmin(adminId, cancellationToken);
            if (deletedAdmin != null)
            {
                deletedAdmin.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedAdmin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Domain.Core.Admin.Entities.Admin> UpdateAdmin(Domain.Core.Admin.Entities.Admin updatedAdmin, CancellationToken cancellationToken)
        {
            var updatingAdmin = await GetAdmin(updatedAdmin.Id, cancellationToken);
            if (updatingAdmin != null)
            {
                updatingAdmin.FirstName = updatedAdmin.FirstName;
                updatingAdmin.LastName = updatedAdmin.LastName;
                updatingAdmin.PhoneNumber = updatedAdmin.PhoneNumber;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingAdmin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Admin.Entities.Admin> GetAdmin(int adminId, CancellationToken cancellationToken)
        {
            var admin = await _homeServiceDbContext.Admins
                .FirstOrDefaultAsync(a => a.Id == adminId, cancellationToken);

            if (admin != null)
            {
                return admin;
            }

            throw new Exception($"admin with id {adminId} not found");
        }
        #endregion
    }
}
