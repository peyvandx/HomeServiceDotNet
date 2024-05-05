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
        public Task<Admin.Entities.Admin> GetAdminById(int adminId, CancellationToken cancellationToken);
        public Task<List<Admin.Entities.Admin>> GetAdmins(CancellationToken cancellationToken);
        public Task<Admin.Entities.Admin> UpdateAdmin(Admin.Entities.Admin updatingAdmin, CancellationToken cancellationToken);
        public Task<Admin.Entities.Admin> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken);
        public Task<Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken);
    }
}
