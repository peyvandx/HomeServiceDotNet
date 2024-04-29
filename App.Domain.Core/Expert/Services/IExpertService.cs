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
        public void CreateExpert(ExpertDto expertDto);
        public void UpdateExpert(ExpertDto expertDto);
        public void SoftDeleteExpert(int  expertId);
        public void HardDeleteExpert(int  expertId);
        public void GetExpertById(int expertId);
        public void GetExperts();
        public void CreateProposal(ProposalDto proposalDto);
        public void UpdateProposal(ProposalDto proposalDto);
        public void SoftDeleteProposal(int proposalId);
        public void HardDeleteProposal(int proposalId);
        public void GetProposalById(int proposalId);
        public void GetProposals();
        public void CreateService(ServiceDto serviceDto);
        public void UpdateService(ServiceDto serviceDto);
        public void SoftDeleteService(int serviceId);
        public void HardDeleteService(int serviceId);
        public void GetServiceById(int serviceId);
        public void GetServices();
        public void CreateSkill(SkillDto skillDto);
        public void UpdateSkill(SkillDto skillDto);
        public void SoftDeleteSkill(int skillId);
        public void HardDeleteSkill(int skillId);
        public void GetSkillById(int skillId);
        public void GetSkills();
        public void CreateCategory(CategoryDto categoryDto);
        public void UpdateCategory(CategoryDto categoryDto);
        public void SoftDeleteCategory(int categoryId);
        public void HardDeleteCategory(int categoryId);
        public void GetCategoryById(int categoryId);
        public void GetCategories();
    }
}
