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
        public Core.Admin.Entities.Admin CreateAdmin(Core.Admin.DTOs.AdminDto adminDto)
        {
            var signingUpAdmin = new Core.Admin.Entities.Admin();
            signingUpAdmin.FirstName = adminDto.FirstName;
            signingUpAdmin.LastName = adminDto.LastName;
            signingUpAdmin.PhoneNumber = adminDto.PhoneNumber;
            signingUpAdmin.SignUpDate = DateTime.Now;
            return _adminRepository.CreateAdmin(signingUpAdmin);
        }

        public Core.Admin.Entities.Admin GetAdminById(int adminId)
        {
            return _adminRepository.GetAdminById(adminId);
        }

        public List<Core.Admin.Entities.Admin> GetAdmins()
        {
            return _adminRepository.GetAdmins();
        }

        public Core.Admin.Entities.Admin HardDeleteAdmin(int adminId)
        {
            return _adminRepository.HardDeleteAdmin(adminId);
        }

        public Core.Admin.Entities.Admin SoftDeleteAdmin(int adminId)
        {
            return _adminRepository.SoftDeleteAdmin(adminId);
        }

        public Core.Admin.Entities.Admin UpdateAdmin(Core.Admin.DTOs.AdminDto adminDto)
        {
            var updatingAdmin = new Core.Admin.Entities.Admin();
            updatingAdmin.FirstName = adminDto.FirstName;
            updatingAdmin.LastName = adminDto.LastName;
            updatingAdmin.PhoneNumber = adminDto.PhoneNumber;
            return _adminRepository.UpdateAdmin(updatingAdmin);
        }
    }
}
