using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
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
    public class SkillRepository : ISkillRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<SkillRepository> _logger;
        #endregion

        #region Ctors
        public SkillRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<SkillRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Skill> CreateSkill(Skill submittedSkill, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Skills.AddAsync(submittedSkill, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Skill has been successfully added to the database.");
            return submittedSkill;
        }

        public async Task<SkillDto> GetSkillById(int skillId, CancellationToken cancellationToken)
        {
            var skill = _memoryCache.Get<SkillDto>("skillDto");
            if (skill is null)
            {
                skill = await _homeServiceDbContext.Skills
                .Select(a => new Domain.Core.Expert.DTOs.SkillDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    SelfRate = a.SelfRate,
                }).FirstOrDefaultAsync(a => a.Id == skillId, cancellationToken);

                if (skill != null)
                {
                    _memoryCache.Set("skillDto", skill, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("skillDto returned from database, and cached in memory successfully.");
                    return skill;
                }
                else
                {
                    _logger.LogError("We expected the skillDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("skillDto returned from InMemoryCache.");
            return skill;
        }

        public async Task<List<SkillDto>> GetSkills(CancellationToken cancellationToken)
        {
            var skills = _memoryCache.Get<List<SkillDto>>("skillDtos");

            if (skills is null)
            {
                skills = await _homeServiceDbContext.Skills
                .Select(a => new SkillDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    SelfRate = a.SelfRate
                }).ToListAsync(cancellationToken);

                if (skills is null)
                {
                    _logger.LogError("We expected the skillDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("skillDtos", skills, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("skillDtos returned from database, and cached in memory successfully.");
                    return skills;
                }
            }
            _logger.LogInformation("skillDtos returned from InMemoryCache.");
            return skills;
        }
        //{
        //    var skills = await _homeServiceDbContext.Skills.ToListAsync(cancellationToken);
        //    if (skills != null)
        //    {
        //        return skills;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        //public async Task<Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken)
        //{
        //    var deletedSkill = await GetSkill(skillId, cancellationToken);
        //    if (deletedSkill != null)
        //    {
        //        deletedSkill.IsDeleted = true;
        //        _homeServiceDbContext.Skills.Remove(deletedSkill);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedSkill;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<SkillSoftDeleteDto> SoftDeleteSkill(int skillId, CancellationToken cancellationToken)
        {
            var deletedSkill = await GetSkillSoftDeleteDto(skillId, cancellationToken);
            deletedSkill.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedSkill;
        }

        public async Task<SkillDto> UpdateSkill(Skill updatedSkill, CancellationToken cancellationToken)
        {
            var updatingSkill = await GetSkillDto(updatedSkill.Id, cancellationToken);
            updatingSkill.Title = updatedSkill.Title;
            updatingSkill.Description = updatedSkill.Description;
            updatingSkill.SelfRate = updatedSkill.SelfRate;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingSkill;
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.DTOs.SkillDto> GetSkillDto(int skillId, CancellationToken cancellationToken)
        {
            var skill = _memoryCache.Get<SkillDto>("skillDto");
            if (skill is null)
            {
                skill = await _homeServiceDbContext.Skills
                .Select(a => new SkillDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                }).FirstOrDefaultAsync(a => a.Id == skillId, cancellationToken);

                if (skill != null)
                {
                    _memoryCache.Set("skillDto", skill, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("skillDto has been returned form database and cached in memory successfully.");
                    return skill;
                }
                _logger.LogError($"skill with id {skillId} not found in GetSkillDto method.");
                throw new Exception($"skill with id {skillId} not found.");
            }
            _logger.LogInformation("skillDto returned from InMemeoryCache in GetSkillDto method.");
            return skill;

        }

        private async Task<Domain.Core.Expert.DTOs.SkillSoftDeleteDto> GetSkillSoftDeleteDto(int skillId, CancellationToken cancellationToken)
        {
            var skill = _memoryCache.Get<SkillSoftDeleteDto>("skillSoftDeleteDto");
            if (skill is null)
            {
                skill = await _homeServiceDbContext.Skills
                .Select(a => new SkillSoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == skillId, cancellationToken);

                if (skill != null)
                {
                    _memoryCache.Set("skillSoftDeleteDto", skill, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("skillSoftDeleteDto has been returned form database and cached in memory successfully.");
                    return skill;
                }
                _logger.LogError($"skill with id {skillId} not found in GetSkillSoftDeleteDto method.");
                throw new Exception($"skill with id {skillId} not found.");
            }
            _logger.LogInformation("skillSoftDeleteDto returned from InMemeoryCache in GetSkillSoftDeleteDto method.");
            return skill;

        }
        #endregion
    }
}
