using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Services
{
    public interface IExpertService
    {
        public Expert.Entities.Expert CreateExpert(ExpertDto expertDto);
        public Expert.Entities.Expert UpdateExpert(ExpertDto expertDto);
        public Expert.Entities.Expert SoftDeleteExpert(int expertId);
        public Expert.Entities.Expert HardDeleteExpert(int expertId);
        public Expert.Entities.Expert GetExpertById(int expertId);
        public List<Expert.Entities.Expert> GetExperts();
        public Expert.Entities.Proposal CreateProposal(ProposalDto proposalDto);
        public Expert.Entities.Proposal UpdateProposal(ProposalDto proposalDto);
        public Expert.Entities.Proposal SoftDeleteProposal(int proposalId);
        public Expert.Entities.Proposal HardDeleteProposal(int proposalId);
        public Expert.Entities.Proposal GetProposalById(int proposalId);
        public List<Expert.Entities.Proposal> GetProposals();
        public Expert.Entities.Service CreateService(ServiceDto serviceDto);
        public Expert.Entities.Service UpdateService(ServiceDto serviceDto);
        public Expert.Entities.Service SoftDeleteService(int serviceId);
        public Expert.Entities.Service HardDeleteService(int serviceId);
        public Expert.Entities.Service GetServiceById(int serviceId);
        public List<Expert.Entities.Service> GetServices();
        public Expert.Entities.Skill CreateSkill(SkillDto skillDto);
        public Expert.Entities.Skill UpdateSkill(SkillDto skillDto);
        public Expert.Entities.Skill SoftDeleteSkill(int skillId);
        public Expert.Entities.Skill HardDeleteSkill(int skillId);
        public Expert.Entities.Skill GetSkillById(int skillId);
        public List<Expert.Entities.Skill> GetSkills();
        public Expert.Entities.Category CreateCategory(CategoryDto categoryDto);
        public Expert.Entities.Category UpdateCategory(CategoryDto categoryDto);
        public Expert.Entities.Category SoftDeleteCategory(int categoryId);
        public Expert.Entities.Category HardDeleteCategory(int categoryId);
        public Expert.Entities.Category GetCategoryById(int categoryId);
        public List<Expert.Entities.Category> GetCategories();
    }
}
