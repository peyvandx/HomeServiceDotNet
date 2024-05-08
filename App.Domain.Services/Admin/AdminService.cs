﻿using App.Domain.Core.Admin.Data;
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
        #region Fields
        private readonly IAdminRepository _adminRepository;
        #endregion

        #region Ctors
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        #endregion

        #region Implementations
        public async Task<Core.Admin.Entities.Admin> CreateAdmin(Core.Admin.DTOs.AdminDto adminDto, CancellationToken cancellationToken)
        {
            var signingUpAdmin = new Core.Admin.Entities.Admin();
            signingUpAdmin.FirstName = adminDto.FirstName;
            signingUpAdmin.LastName = adminDto.LastName;
            signingUpAdmin.PhoneNumber = adminDto.PhoneNumber;
            signingUpAdmin.SignUpDate = DateTime.Now;
            return await _adminRepository.CreateAdmin(signingUpAdmin, cancellationToken);
        }

        public async Task<Core.Admin.Entities.Admin> GetAdminById(int adminId, CancellationToken cancellationToken)
            => await _adminRepository.GetAdminById(adminId, cancellationToken);

        public async Task<List<Core.Admin.Entities.Admin>> GetAdmins(CancellationToken cancellationToken)
            => await _adminRepository.GetAdmins(cancellationToken);

        public async Task<Core.Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken)
            => await _adminRepository.HardDeleteAdmin(adminId, cancellationToken);

        public async Task<Core.Admin.Entities.Admin> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken)
            => await _adminRepository.SoftDeleteAdmin(adminId, cancellationToken);

        public async Task<Core.Admin.Entities.Admin> UpdateAdmin(Core.Admin.DTOs.AdminDto adminDto, CancellationToken cancellationToken)
        {
            var updatingAdmin = new Core.Admin.Entities.Admin();
            updatingAdmin.FirstName = adminDto.FirstName;
            updatingAdmin.LastName = adminDto.LastName;
            updatingAdmin.PhoneNumber = adminDto.PhoneNumber;
            return await _adminRepository.UpdateAdmin(updatingAdmin, cancellationToken);
        }
        #endregion
    }
}
