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
        public Task<Admin.Entities.Admin> CreateAdmin(AdminDto adminDto, CancellationToken cancellationToken);
        public Task<AdminProfileDto> GetAdminById(int adminId, CancellationToken cancellationToken);
        public Task<List<AdminProfileDto>> GetAdmins(CancellationToken cancellationToken);
        public Task<Admin.DTOs.AdminDto> UpdateAdmin(AdminDto adminDto, CancellationToken cancellationToken);
        public Task<Domain.Core.Admin.DTOs.ProposalSoftDeleteDto> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken);
        //public Task<Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken);
    }
}
