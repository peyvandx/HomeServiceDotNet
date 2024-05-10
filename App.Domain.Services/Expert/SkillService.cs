using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class SkillService : ISkillService
    {
        #region Fields
        private readonly ISkillRepository _skillRepository;
        #endregion

        #region Ctors
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        #endregion

        #region Implementations
        public async Task<Skill> CreateSkill(SkillDto skillDto, CancellationToken cancellationToken)
        {
            var creatingSkill = new Skill();
            creatingSkill.CreatedAt = DateTime.Now;
            creatingSkill.Title = skillDto.Title;
            creatingSkill.Description = skillDto.Description;
            creatingSkill.SelfRate = skillDto.SelfRate;
            creatingSkill.ExpertId = skillDto.ExpertId;
            return await _skillRepository.CreateSkill(creatingSkill, cancellationToken);
        }


        public async Task<SkillDto> GetSkillById(int skillId, CancellationToken cancellationToken)
            => await _skillRepository.GetSkillById(skillId, cancellationToken);

        public async Task<List<SkillDto>> GetSkills(CancellationToken cancellationToken)
            => await _skillRepository.GetSkills(cancellationToken);

        //public async Task<Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken)
        //    => await _skillRepository.HardDeleteSkill(skillId, cancellationToken);

        public async Task<SkillSoftDeleteDto> SoftDeleteSkill(int skillId, CancellationToken cancellationToken)
            => await _skillRepository.SoftDeleteSkill(skillId, cancellationToken);

        public async Task<SkillDto> UpdateSkill(SkillDto skillDto, CancellationToken cancellationToken)
        {
            var updatedSkill = new Skill();
            updatedSkill.Title = skillDto.Title;
            updatedSkill.Description = skillDto.Description;
            updatedSkill.SelfRate = skillDto.SelfRate;
            return await _skillRepository.UpdateSkill(updatedSkill, cancellationToken);
        }

        #endregion
    }
}
