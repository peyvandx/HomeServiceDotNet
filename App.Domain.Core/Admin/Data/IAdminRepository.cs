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
        public Task<Admin.Entities.Admin> CreateAdmin(Admin.Entities.Admin signingUpAdmin, CancellationToken cancellationToken);
        public Task<AdminProfileDto> GetAdminById(int adminId, CancellationToken cancellationToken);
        public Task<List<AdminProfileDto>> GetAdmins(CancellationToken cancellationToken);
        public Task<Admin.DTOs.AdminDto> UpdateAdmin(Admin.Entities.Admin updatingAdmin, CancellationToken cancellationToken);
        public Task<Domain.Core.Admin.DTOs.AdminSoftDeleteDto> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken);
        //public Task<Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken);
    }
}
