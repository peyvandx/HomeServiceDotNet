using App.Domain.Core.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.AppServices
{
    public interface IAdminAppService
    {
        public Admin.Entities.Admin CreateAdmin(AdminDto adminDto);
        public Admin.Entities.Admin GetAdminById(int adminId);
        public List<Admin.Entities.Admin> GetAdmins();
        public Admin.Entities.Admin UpdateAdmin(AdminDto adminDto);
        public Admin.Entities.Admin SoftDeleteAdmin(int adminId);
        public Admin.Entities.Admin HardDeleteAdmin(int adminId);
    }
}
