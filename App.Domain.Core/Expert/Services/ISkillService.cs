using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Services
{
    public interface ISkillService
    {
        public Task<Expert.Entities.Skill> CreateSkill(SkillDto skillDto, CancellationToken cancellationToken);
        public Task<SkillDto> UpdateSkill(SkillDto skillDto, CancellationToken cancellationToken);
        public Task<SkillSoftDeleteDto> SoftDeleteSkill(int skillId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<SkillDto> GetSkillById(int skillId, CancellationToken cancellationToken);
        public Task<List<SkillDto>> GetSkills(CancellationToken cancellationToken);
    }
}
