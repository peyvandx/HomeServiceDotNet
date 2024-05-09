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
        public Task<Admin.Entities.Admin> CreateAdmin(DTOs.AdminDto adminDto, CancellationToken cancellationToken);
        public Task<Domain.Core.Admin.DTOs.AdminProfileDto> GetAdminById(int adminId, CancellationToken cancellationToken);
        public Task<List<AdminProfileDto>> GetAdmins(CancellationToken cancellationToken);
        public Task<Admin.DTOs.AdminDto> UpdateAdmin(DTOs.AdminDto adminDto, CancellationToken cancellationToken);
        public Task<Domain.Core.Admin.DTOs.AdminSoftDeleteDto> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken);
        //public Task<Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken);
    }
}
