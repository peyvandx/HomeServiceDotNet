using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface ISkillRepository
    {
        public Task<Expert.Entities.Skill> CreateSkill(Expert.Entities.Skill submittedSkill, CancellationToken cancellationToken);
        public Task<SkillDto> UpdateSkill(Expert.Entities.Skill updatedSkill, CancellationToken cancellationToken);
        public Task<SkillSoftDeleteDto> SoftDeleteSkill(int skillId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<SkillDto> GetSkillById(int skillId, CancellationToken cancellationToken);
        public Task<List<SkillDto>> GetSkills(CancellationToken cancellationToken);
    }
}
