using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class SkillAppService : ISkillAppService
    {
        #region Fields
        private readonly ISkillService _skillService;
        #endregion

        #region Ctors
        public SkillAppService(ISkillService skillService)
        {
            _skillService = skillService;
        }
        #endregion

        #region Implementations
        public async Task<Skill> CreateSkill(SkillDto skillDto, CancellationToken cancellationToken)
            => await _skillService.CreateSkill(skillDto, cancellationToken);

        public async Task<SkillDto> GetSkillById(int skillId, CancellationToken cancellationToken)
            => await _skillService.GetSkillById(skillId, cancellationToken);

        public async Task<List<SkillDto>> GetSkills(CancellationToken cancellationToken)
            => await _skillService.GetSkills(cancellationToken);

        //public async Task<Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken)
        //    => await _skillService.HardDeleteSkill(skillId, cancellationToken);

        public async Task<SkillSoftDeleteDto> SoftDeleteSkill(int skillId, CancellationToken cancellationToken)
            => await _skillService.SoftDeleteSkill(skillId, cancellationToken);

        public async Task<SkillDto> UpdateSkill(SkillDto skillDto, CancellationToken cancellationToken)
            => await _skillService.UpdateSkill(skillDto, cancellationToken);
        #endregion
    }
}
