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
        public Core.Admin.Entities.Admin CreateAdmin(Core.Admin.DTOs.AdminDto adminDto)
        {
            return _adminService.CreateAdmin(adminDto);
        }

        public Core.Admin.Entities.Admin GetAdminById(int adminId)
        {
            return _adminService.GetAdminById(adminId);
        }

        public List<Core.Admin.Entities.Admin> GetAdmins()
        {
            return _adminService.GetAdmins();
        }

        public Core.Admin.Entities.Admin HardDeleteAdmin(int adminId)
        {
            return _adminService.HardDeleteAdmin(adminId);
        }

        public Core.Admin.Entities.Admin SoftDeleteAdmin(int adminId)
        {
            return _adminService.HardDeleteAdmin(adminId);
        }

        public Core.Admin.Entities.Admin UpdateAdmin(Core.Admin.DTOs.AdminDto adminDto)
        {
            return _adminService.UpdateAdmin(adminDto);
        }
    }
}
