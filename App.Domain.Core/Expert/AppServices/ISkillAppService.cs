﻿using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.AppServices
{
    public interface ISkillAppService
    {
        public Task<Expert.Entities.Skill> CreateSkill(SkillDto skillDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> UpdateSkill(SkillDto skillDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> SoftDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> HardDeleteSkill(int skillId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Skill> GetSkillById(int skillId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Skill>> GetSkills(CancellationToken cancellationToken);
    }
}
