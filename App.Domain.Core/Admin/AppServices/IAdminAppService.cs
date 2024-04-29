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
        public void CreateAdmin(AdminDto adminDto);
        public void GetAdminById(int adminId);
        public void GetAdmins();
        public void UpdateAdmin(AdminDto adminDto);
        public void SoftDeleteAdmin(int adminId);
        public void HardDeleteAdmin(int adminId);
    }
}
