using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
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
        #endregion

        #region Ctors
        public SkillRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Skill> CreateSkill(Skill submittedSkill, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Skills.AddAsync(submittedSkill, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedSkill;
        }

        public async Task<Skill> GetSkillById(int skillId, CancellationToken cancellationToken)
        {
            var skill = await _homeServiceDbContext.Skills.FirstOrDefaultAsync(s => s.Id == skillId, cancellationToken);
            if (skill != null)
            {
                return skill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Skill>> GetSkills(CancellationToken cancellationToken) => await _homeServiceDbContext.Skills.ToListAsync(cancellationToken);
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

        public async Task<Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken)
        {
            var deletedSkill = await GetSkill(skillId, cancellationToken);
            if (deletedSkill != null)
            {
                deletedSkill.IsDeleted = true;
                _homeServiceDbContext.Skills.Remove(deletedSkill);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Skill> SoftDeleteSkill(int skillId, CancellationToken cancellationToken)
        {
            var deletedSkill = await GetSkill(skillId, cancellationToken);
            if (deletedSkill != null)
            {
                deletedSkill.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Skill> UpdateSkill(Skill updatedSkill, CancellationToken cancellationToken)
        {
            var updatingSkill = await GetSkill(updatedSkill.Id, cancellationToken);
            if (updatingSkill != null)
            {
                updatingSkill.Title = updatedSkill.Title;
                updatingSkill.Description = updatedSkill.Description;
                updatingSkill.SelfRate = updatedSkill.SelfRate;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.Entities.Skill> GetSkill(int skillId, CancellationToken cancellationToken)
        {
            var skill = await _homeServiceDbContext.Skills
                .FirstOrDefaultAsync(a => a.Id == skillId, cancellationToken);

            if (skill != null)
            {
                return skill;
            }

            throw new Exception($"admin with id {skillId} not found");
        }
        #endregion
    }
}
