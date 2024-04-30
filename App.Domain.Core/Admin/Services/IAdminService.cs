using App.Domain.Core.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Services
{
    public interface IAdminService
    {
        public Admin.Entities.Admin CreateAdmin(DTOs.AdminDto adminDto);
        public Admin.Entities.Admin GetAdminById(int adminId);
        public List<Admin.Entities.Admin> GetAdmins();
        public Admin.Entities.Admin UpdateAdmin(DTOs.AdminDto adminDto);
        public Admin.Entities.Admin SoftDeleteAdmin(int adminId);
        public Admin.Entities.Admin HardDeleteAdmin(int adminId);
    }
}
