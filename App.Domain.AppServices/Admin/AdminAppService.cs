using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IAdminService _adminService;

        public AdminAppService(IAdminService adminService)
        {
            _adminService = adminService;
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
