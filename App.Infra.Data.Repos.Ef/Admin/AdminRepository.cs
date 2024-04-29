using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.DTOs;
using App.Infra.Db.SqlServer.Ef.DbContext;
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
        public void CreateAdmin(AdminDto adminDto)
        {
            throw new NotImplementedException();
        }

        public void GetAdminById(int adminId)
        {
            throw new NotImplementedException();
        }

        public void GetAdmins()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteAdmin(int adminId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteAdmin(int adminId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdmin(AdminDto adminDto)
        {
            throw new NotImplementedException();
        }
    }
}
