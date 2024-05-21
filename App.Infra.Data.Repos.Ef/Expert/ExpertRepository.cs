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

        public async Task<Domain.Core.Expert.DTOs.ExpertDto> GetExpertById(int expertId, CancellationToken cancellationToken)
        {
            var expert = _memoryCache.Get<ExpertDto>("expertDto");
            if (expert is null)
            {
                expert = await _homeServiceDbContext.Experts
                .Select(a => new Domain.Core.Expert.DTOs.ExpertDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).FirstOrDefaultAsync(a => a.Id == expertId, cancellationToken);

                if (expert != null)
                {
                    _memoryCache.Set("expertDto", expert, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("expertDto returned from database, and cached in memory successfully.");
                    return expert;
                }
                else
                {
                    _logger.LogError("We expected the expertDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("expertDto returned from InMemoryCache.");
            return expert;
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

        public async Task<Domain.Core.Expert.DTOs.ExpertDto> UpdateExpert(Domain.Core.Expert.Entities.Expert updatedExpert, CancellationToken cancellationToken)
        {
            var updatingExpert = await GetExpertDto(updatedExpert.Id, cancellationToken);
            updatingExpert.FirstName = updatedExpert.FirstName;
            updatingExpert.LastName = updatedExpert.LastName;
            updatingExpert.ProfileImage = updatedExpert.ProfileImage;
            updatingExpert.Age = updatedExpert.Age;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingExpert;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.DTOs.ExpertDto> GetExpertDto(int expertId, CancellationToken cancellationToken)
        {
            var expert = _memoryCache.Get<ExpertDto>("expertDto");
            if (expert is null)
            {
                expert = await _homeServiceDbContext.Experts
                .Select(a => new ExpertDto()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    ProfileImage = a.ProfileImage,
                }).FirstOrDefaultAsync(a => a.Id == expertId, cancellationToken);

                if (expert != null)
                {
                    _memoryCache.Set("expertDto", expert, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("expertDto has been returned form database and cached in memory successfully.");
                    return expert;
                }
                _logger.LogError($"expert with id {expertId} not found in GetExpertDto method.");
                throw new Exception($"expert with id {expertId} not found.");
            }
            _logger.LogInformation("expertDto returned from InMemeoryCache in GetExpertDto method.");
            return expert;
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
