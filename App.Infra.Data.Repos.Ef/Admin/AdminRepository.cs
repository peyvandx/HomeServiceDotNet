using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.DTOs;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Admin
{
    public class AdminRepository : IAdminRepository
    {
        private readonly HomeServiceDbContext _homeServiceDbContext;

        public AdminRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        public Domain.Core.Admin.Entities.Admin CreateAdmin(Domain.Core.Admin.Entities.Admin signingUpAdmin)
        {
            _homeServiceDbContext.Admins.Add(signingUpAdmin);
            _homeServiceDbContext.SaveChanges();
            return signingUpAdmin;
        }

        public Domain.Core.Admin.Entities.Admin GetAdminById(int adminId)
        {
            return _homeServiceDbContext.Admins.FirstOrDefault(a => a.Id == adminId);
        }

        public List<Domain.Core.Admin.Entities.Admin> GetAdmins()
        {
            return _homeServiceDbContext.Admins.ToList();
        }

        public Domain.Core.Admin.Entities.Admin HardDeleteAdmin(int adminId)
        {
            var deletedAdmin = GetAdminById(adminId);
            if (deletedAdmin != null)
            {
                deletedAdmin.IsDeleted = true;
                _homeServiceDbContext.Admins.Remove(deletedAdmin);
                _homeServiceDbContext.SaveChanges();
                return deletedAdmin;
            }else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Admin.Entities.Admin SoftDeleteAdmin(int adminId)
        {
            var deletedAdmin = GetAdminById(adminId);
            if (deletedAdmin != null)
            {
                deletedAdmin.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedAdmin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Admin.Entities.Admin UpdateAdmin(Domain.Core.Admin.Entities.Admin updatedAdmin)
        {
            var updatingAdmin = GetAdminById(updatedAdmin.Id);
            if (updatingAdmin != null)
            {
                updatingAdmin.FirstName = updatedAdmin.FirstName;
                updatingAdmin.LastName = updatedAdmin.LastName;
                updatingAdmin.PhoneNumber = updatedAdmin.PhoneNumber;
                _homeServiceDbContext.SaveChanges();
                return updatingAdmin;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
    }
}
