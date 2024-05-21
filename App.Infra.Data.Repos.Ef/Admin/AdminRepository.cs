using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Admin
{
    public class AdminRepository : IAdminRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<AdminRepository> _logger;
        #endregion

        #region Ctors
        public AdminRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<AdminRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Domain.Core.Admin.Entities.Admin> CreateAdmin(Domain.Core.Admin.Entities.Admin signingUpAdmin, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Admins.AddAsync(signingUpAdmin, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Admin has been successfully added to the database.");
            return signingUpAdmin;
        }

        public async Task<Domain.Core.Admin.DTOs.AdminProfileDto> GetAdminById(int adminId, CancellationToken cancellationToken)
        {
            var admin = _memoryCache.Get<AdminProfileDto?>("adminProfileDto");
            if (admin is null)
            {
                admin = await _homeServiceDbContext.Admins
                .Select(a => new Domain.Core.Admin.DTOs.AdminProfileDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).FirstOrDefaultAsync(a => a.Id == adminId, cancellationToken);

                if (admin != null)
                {
                    _memoryCache.Set("adminProfileDto", admin, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("AdminProfileDto returned from database, and cached in memory successfully.");
                    return admin;
                }
                else
                {
                    _logger.LogError("We expected the AdminProfileDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("AdminProfileDto returned from InMemoryCache.");
            return admin;

        }

        public async Task<List<Domain.Core.Admin.DTOs.AdminProfileDto>> GetAdmins(CancellationToken cancellationToken)
        {
            var admins = _memoryCache.Get<List<AdminProfileDto>>("adminProfileDtos");

            if (admins is null)
            {
                admins = await _homeServiceDbContext.Admins
                .Select(a => new AdminProfileDto()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).ToListAsync(cancellationToken);

                if (admins is null)
                {
                    _logger.LogError("We expected the AdminProfileDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("adminProfileDtos", admins, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("AdminProfileDtos returned from database, and cached in memory successfully.");
                    return admins;
                }
            }
            _logger.LogInformation("AdminProfileDtos returned from InMemoryCache.");
            return admins;
        }

        //public async Task<Domain.Core.Admin.Entities.Admin> HardDeleteAdmin(int adminId, CancellationToken cancellationToken)
        //{
        //    var deletedAdmin = await GetAdmin(adminId, cancellationToken);
        //    if (deletedAdmin != null)
        //    {
        //        deletedAdmin.IsDeleted = true;
        //        _homeServiceDbContext.Admins.Remove(deletedAdmin);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedAdmin;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Domain.Core.Admin.DTOs.AdminSoftDeleteDto> SoftDeleteAdmin(int adminId, CancellationToken cancellationToken)
        {
            var deletedAdmin = await GetAdminSoftDeleteDto(adminId, cancellationToken);
            deletedAdmin.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Admin has been successfully deleted.");
            return deletedAdmin;
        }

        public async Task<Domain.Core.Admin.DTOs.AdminDto> UpdateAdmin(Domain.Core.Admin.Entities.Admin updatedAdmin, CancellationToken cancellationToken)
        {
            var updatingAdmin = await GetAdminDto(updatedAdmin.Id, cancellationToken);
            updatingAdmin.FirstName = updatedAdmin.FirstName;
            updatingAdmin.LastName = updatedAdmin.LastName;
            updatingAdmin.ProfileImage = updatedAdmin.ProfileImage;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Admin updated successfully.");
            return updatingAdmin;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Admin.DTOs.AdminDto> GetAdminDto(int adminId, CancellationToken cancellationToken)
        {
            var admin = _memoryCache.Get<AdminDto>("adminDto");
            if (admin is null)
            {
                admin = await _homeServiceDbContext.Admins
                .Select(a => new AdminDto()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).FirstOrDefaultAsync(a => a.Id == adminId, cancellationToken);

                if (admin != null)
                {
                    _memoryCache.Set("adminDto", admin, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("adminDto has been returned form database and cached in memory successfully.");
                    return admin;
                }
                _logger.LogError($"admin with id {adminId} not found in GetAdminDto method.");
                throw new Exception($"admin with id {adminId} not found.");
            }
            _logger.LogInformation("AdminDto returned from InMemeoryCache in GetAdminDto method.");
            return admin;

        }

        private async Task<Domain.Core.Admin.DTOs.AdminSoftDeleteDto> GetAdminSoftDeleteDto(int adminId, CancellationToken cancellationToken)
        {
            var admin = _memoryCache.Get<AdminSoftDeleteDto>("adminSoftDeleteDto");
            if (admin is null)
            {
                admin = await _homeServiceDbContext.Admins
                .Select(a => new AdminSoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == adminId, cancellationToken);

                if (admin != null)
                {
                    _memoryCache.Set("adminSoftDeleteDto", admin, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("adminSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return admin;
                }
                _logger.LogError($"admin with id {adminId} not found in GetAdminSoftDeleteDto method.");
                throw new Exception($"admin with id {adminId} not found.");
            }
            _logger.LogInformation("adminSoftDeleteDto returned from InMemeoryCache in GetAdminSoftDeleteDto method.");
            return admin;

        }
        #endregion
    }
}
