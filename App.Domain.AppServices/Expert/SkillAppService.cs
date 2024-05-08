using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class SkillAppService : ISkillAppService
    {
        public Task<Skill> CreateSkill(SkillDto skillDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetSkillById(int skillId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkills(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> SoftDeleteSkill(int skillId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> UpdateSkill(SkillDto skillDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
