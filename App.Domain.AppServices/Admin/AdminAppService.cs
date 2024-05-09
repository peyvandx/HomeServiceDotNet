using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class AdminAppService : IAdminAppService
    {
        #region Fields
        private readonly IAdminService _adminService;
        #endregion

        #region Ctors
        public AdminAppService(IAdminService adminService)
        {
            _adminService = adminService;
        }
        #endregion

        #region Implementations
        public async Task<Core.Admin.Entities.Admin> CreateAdmin(Core.Admin.DTOs.AdminDto adminDto, CancellationToken cancellationToken) 
            => await _adminService.CreateAdmin(adminDto, cancellationToken);

        public async Task<AdminProfileDto> GetAdminById(int adminId, CancellationToken cancellationToken) 
            => await _adminService.GetAdminById(adminId, cancellationToken);

        public async Task<List<AdminProfileDto>> GetAdmins(CancellationToken cancellationToken) 
            => await _adminService.GetAdmins(cancellationToken);

        //public async Task<Core.Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken) 
        //    => await _adminService.HardDeleteAdmin(adminId, cancellationToken);

        public async Task<Domain.Core.Admin.DTOs.AdminSoftDeleteDto> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken) 
            => await _adminService.SoftDeleteAdmin(adminId, cancellationToken);

        public async Task<Core.Admin.DTOs.AdminDto> UpdateAdmin(Core.Admin.DTOs.AdminDto adminDto, CancellationToken cancellationToken) 
            => await _adminService.UpdateAdmin(adminDto, cancellationToken);
        #endregion
    }
}
