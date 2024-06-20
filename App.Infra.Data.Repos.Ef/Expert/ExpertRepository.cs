using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Data.Repos.Ef.Admin;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class ExpertRepository : IExpertRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ExpertRepository> _logger;
        #endregion

        #region Ctors
        public ExpertRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<ExpertRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion
        #region Implementations

        public async Task<Domain.Core.Expert.Entities.Expert> CreateExpert(Domain.Core.Expert.Entities.Expert signingUpExpert, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Experts.AddAsync(signingUpExpert, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Expert has been successfully added to the database.");
            return signingUpExpert;
        }

        public async Task<Domain.Core.Expert.DTOs.ExpertDto> GetExpertById(int? expertId, CancellationToken cancellationToken)
        {
            try
            {
                var expert = await _homeServiceDbContext.Experts
                    //.Include(e => e.Services)
                    .Include(e => e.ApplicationUser)
                    .Include(e => e.Address)
                    .ThenInclude(a => a.City)
                    .Select(a => new Domain.Core.Expert.DTOs.ExpertDto
                    {
                        Id = a.Id,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        ProfileImage = a.ProfileImage,
                        Age = a.Age,
                        AboutMe = a.AboutMe,
                        Email = a.ApplicationUser.Email,
                        PhoneNumber = a.ApplicationUser.PhoneNumber,
                        //Services = a.Services,
                        ServiceIds = a.Services.Select(a => a.Id).ToList(),
                        Address = a.Address,
                        InstagramAddress = a.InstagramAddress,
                        FacebookAddress = a.FacebookAddress,
                        TwitterAddress = a.TwitterAddress,
                        LinkedinAddress = a.LinkedinAddress,
                    }).FirstOrDefaultAsync(a => a.Id == expertId, cancellationToken);

                if (expert != null)
                {
                    _logger.LogInformation("expertDto returned from database successfully.");
                    return expert;
                }
                else
                {
                    _logger.LogError("We expected the expertDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            catch (Exception ex)
            {

            }
            return new ExpertDto();
        }

        public Task<int?> GetExpertIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
        {
            var expertId = _homeServiceDbContext.Experts
                .Where(c => c.ApplicationUserId == applicationUserId)
                .Select(c => c.Id)
                .FirstOrDefaultAsync(cancellationToken);

            return expertId;
        }

        public async Task<List<Domain.Core.Expert.DTOs.ExpertDto>> GetExperts(CancellationToken cancellationToken)
        {
            var experts = _memoryCache.Get<List<ExpertDto>>("expertDtos");

            if (experts is null)
            {
                experts = await _homeServiceDbContext.Experts
                .Select(a => new ExpertDto()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).ToListAsync(cancellationToken);

                if (experts is null)
                {
                    _logger.LogError("We expected the expertDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("expertDtos", experts, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("expertDtos returned from database, and cached in memory successfully.");
                    return experts;
                }
            }
            _logger.LogInformation("expertDtos returned from InMemoryCache.");
            return experts;
        }
        //{
        //    var experts = await _homeServiceDbContext.Experts.ToListAsync(cancellationToken);
        //    if (experts != null)
        //    {
        //        return experts;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        //public async Task<Domain.Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        //{
        //    var deletedExpert = await GetExpert(expertId, cancellationToken);
        //    if (deletedExpert != null)
        //    {
        //        deletedExpert.IsDeleted = true;
        //        _homeServiceDbContext.Experts.Remove(deletedExpert);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedExpert;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Domain.Core.Expert.DTOs.ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
        {
            var deletedExpert = await GetExpertSoftDeleteDto(expertId, cancellationToken);
            deletedExpert.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedExpert;
        }

        public async Task<Domain.Core.Expert.DTOs.ExpertDto> UpdateExpert(Domain.Core.Expert.DTOs.ExpertProfileDto updatedExpert, CancellationToken cancellationToken)
        {
            var updatingExpert = await GetExpert(updatedExpert.Id.Value, cancellationToken);

            updatingExpert.Services ??= new List<Service>();

            updatingExpert.Services.Clear();

            if (updatedExpert.ServiceIds is not null)
            {
                foreach (var serviceId in updatedExpert.ServiceIds)
                {
                    var service = await _homeServiceDbContext.Services
                        .FirstOrDefaultAsync(x => x.Id == serviceId, cancellationToken);

                    updatingExpert.Services.Add(service);
                }
            }

            updatingExpert.Address = new Domain.Core.Customer.Entities.Address();
            updatingExpert.FirstName = updatedExpert.FirstName;
            updatingExpert.LastName = updatedExpert.LastName;
            updatingExpert.ProfileImage = updatedExpert.ProfileImageUrl;
            updatingExpert.Age = updatedExpert.Age;
            updatingExpert.AboutMe = updatedExpert.AboutMe;
            updatingExpert.ApplicationUser.PhoneNumber = updatedExpert.PhoneNumber;
            updatingExpert.ApplicationUser.Email = updatedExpert.Email;
            updatingExpert.ApplicationUser.NormalizedEmail = updatedExpert.Email.ToUpper();
            updatingExpert.FacebookAddress = updatedExpert.FacebookAddress;
            updatingExpert.InstagramAddress = updatedExpert.InstagramAddress;
            updatingExpert.TwitterAddress = updatedExpert.TwitterAddress;
            updatingExpert.LinkedinAddress = updatedExpert.LinkedinAddress;
            updatingExpert.Address.Street = updatedExpert.Address.Street;
            updatingExpert.Address.PostalCode = updatedExpert.Address.PostalCode;
            updatingExpert.Address.CityId = updatedExpert.Address.CityId;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            var updatedExpertDto = new ExpertDto();
            updatedExpertDto.Id = updatedExpert.Id;
            updatedExpertDto.FirstName = updatedExpert.FirstName;
            updatedExpertDto.LastName = updatedExpert.LastName;
            updatedExpertDto.Address = updatedExpert.Address;
            updatedExpertDto.Age = updatedExpert.Age;
            updatedExpertDto.AboutMe = updatedExpert.AboutMe;
            return updatedExpertDto;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.Entities.Expert> GetExpert(int expertId, CancellationToken cancellationToken)
        {
            //var expert = _memoryCache.Get<Domain.Core.Expert.Entities.Expert>("expertDto");
            //if (expert is null)
            //{
            //    expert = await _homeServiceDbContext.Experts
            //    .Include(c => c.Address)
            //    .ThenInclude(a => a.City)
            //    .FirstOrDefaultAsync(c => c.Id == expertId, cancellationToken);

            //    if (expert != null)
            //    {
            //        _memoryCache.Set("expertDto", expert, new MemoryCacheEntryOptions()
            //        {
            //            SlidingExpiration = TimeSpan.FromSeconds(120)
            //        });
            //        _logger.LogInformation("expertDto has been returned form database and cached in memory successfully.");
            //        return expert;
            //    }
            //    _logger.LogError($"admin with id {expertId} not found in GetExpert method.");
            //    throw new Exception($"admin with id {expertId} not found.");
            //}
            //_logger.LogInformation("expertDto returned from InMemeoryCache in GetExpert method.");
            //return expert;
            try
            {
                var expert = await _homeServiceDbContext.Experts
                .Include(e => e.ApplicationUser)
                .Include(e => e.Services)
                .Include(c => c.Address)
                .ThenInclude(a => a.City)
                .FirstOrDefaultAsync(c => c.Id == expertId, cancellationToken);
                if (expert == null)
                {
                    throw new Exception("expert is null");
                }
                else
                {
                    return expert;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<ExpertSoftDeleteDto> GetExpertSoftDeleteDto(int expertId, CancellationToken cancellationToken)
        {
            var expert = _memoryCache.Get<ExpertSoftDeleteDto>("expertSoftDeleteDto");
            if (expert is null)
            {
                expert = await _homeServiceDbContext.Experts
                .Select(a => new ExpertSoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == expertId, cancellationToken);

                if (expert != null)
                {
                    _memoryCache.Set("expertSoftDeleteDto", expert, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("expertSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return expert;
                }
                _logger.LogError($"expert with id {expertId} not found in GetExpertSoftDeleteDto method.");
                throw new Exception($"expert with id {expertId} not found.");
            }
            _logger.LogInformation("expertSoftDeleteDto returned from InMemeoryCache in GetExpertSoftDeleteDto method.");
            return expert;

        }
        #endregion
    }
}
