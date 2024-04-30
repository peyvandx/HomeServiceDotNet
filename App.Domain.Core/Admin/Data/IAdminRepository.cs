using App.Domain.Core.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Data
{
    public interface IAdminRepository
    {
        public Admin.Entities.Admin CreateAdmin(Admin.Entities.Admin signingUpAdmin);
        public Admin.Entities.Admin GetAdminById(int adminId);
        public List<Admin.Entities.Admin> GetAdmins();
        public Admin.Entities.Admin UpdateAdmin(Admin.Entities.Admin updatingAdmin);
        public Admin.Entities.Admin SoftDeleteAdmin(int adminId);
        public Admin.Entities.Admin HardDeleteAdmin(int adminId);
    }
}
