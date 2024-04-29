using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Admin
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
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
