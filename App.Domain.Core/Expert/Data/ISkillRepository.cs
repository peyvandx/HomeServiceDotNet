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
        public Task<Expert.Entities.Skill> UpdateSkill(Expert.Entities.Skill updatedSkill, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> SoftDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> GetSkillById(int skillId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Skill>> GetSkills(CancellationToken cancellationToken);
    }
}
