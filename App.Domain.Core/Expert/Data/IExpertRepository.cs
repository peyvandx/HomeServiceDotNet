using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface IExpertRepository
    {
        public Expert.Entities.Expert CreateExpert(Expert.Entities.Expert signingUpExpert);
        public Expert.Entities.Expert UpdateExpert(Expert.Entities.Expert updatedExpert);
        public Expert.Entities.Expert SoftDeleteExpert(int expertId);
        public Expert.Entities.Expert HardDeleteExpert(int expertId);
        public Expert.Entities.Expert GetExpertById(int expertId);
        public List<Expert.Entities.Expert> GetExperts();
        public Expert.Entities.Proposal CreateProposal(Expert.Entities.Proposal submittedProposal);
        public Expert.Entities.Proposal UpdateProposal(Expert.Entities.Proposal updatedProposal);
        public Expert.Entities.Proposal SoftDeleteProposal(int proposalId);
        public Expert.Entities.Proposal HardDeleteProposal(int proposalId);
        public Expert.Entities.Proposal GetProposalById(int proposalId);
        public List<Expert.Entities.Proposal> GetProposals();
        public Expert.Entities.Service CreateService(Expert.Entities.Service createdService);
        public Expert.Entities.Service UpdateService(Expert.Entities.Service updatedService);
        public Expert.Entities.Service SoftDeleteService(int serviceId);
        public Expert.Entities.Service HardDeleteService(int serviceId);
        public Expert.Entities.Service GetServiceById(int serviceId);
        public List<Expert.Entities.Service> GetServices();
        public Expert.Entities.Skill CreateSkill(Expert.Entities.Skill submittedSkill);
        public Expert.Entities.Skill UpdateSkill(Expert.Entities.Skill updatedSkill);
        public Expert.Entities.Skill SoftDeleteSkill(int skillId);
        public Expert.Entities.Skill HardDeleteSkill(int skillId);
        public Expert.Entities.Skill GetSkillById(int skillId);
        public List<Expert.Entities.Skill> GetSkills();
        public Expert.Entities.Category CreateCategory(Expert.Entities.Category createdCategory);
        public Expert.Entities.Category UpdateCategory(Expert.Entities.Category updatedCategory);
        public Expert.Entities.Category SoftDeleteCategory(int categoryId);
        public Expert.Entities.Category HardDeleteCategory(int categoryId);
        public Expert.Entities.Category GetCategoryById(int categoryId);
        public List<Expert.Entities.Category> GetCategories();
    }
}
