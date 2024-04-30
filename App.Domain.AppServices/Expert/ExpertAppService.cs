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
    public class ExpertAppService : IExpertAppService
    {
        private readonly IExpertService _expertService;

        public ExpertAppService(IExpertService expertService)
        {
            _expertService = expertService;
        }

        public Category CreateCategory(CategoryDto categoryDto)
        {
            return _expertService.CreateCategory(categoryDto);
        }

        public Core.Expert.Entities.Expert CreateExpert(ExpertDto expertDto)
        {
            return _expertService.CreateExpert(expertDto);
        }

        public Proposal CreateProposal(ProposalDto proposalDto)
        {
            return _expertService.CreateProposal(proposalDto);
        }

        public Service CreateService(ServiceDto serviceDto)
        {
            return _expertService.CreateService(serviceDto);
        }

        public Skill CreateSkill(SkillDto skillDto)
        {
            return _expertService.CreateSkill(skillDto);
        }

        public List<Category> GetCategories()
        {
            return _expertService.GetCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _expertService.GetCategoryById(categoryId);
        }

        public Core.Expert.Entities.Expert GetExpertById(int expertId)
        {
            return _expertService.GetExpertById(expertId);
        }

        public List<Core.Expert.Entities.Expert> GetExperts()
        {
            return _expertService.GetExperts();
        }

        public Proposal GetProposalById(int proposalId)
        {
            return _expertService.GetProposalById(proposalId);
        }

        public List<Proposal> GetProposals()
        {
            return _expertService.GetProposals();
        }

        public Service GetServiceById(int serviceId)
        {
            return _expertService.GetServiceById(serviceId);
        }

        public List<Service> GetServices()
        {
            return _expertService.GetServices();
        }

        public Skill GetSkillById(int skillId)
        {
            return _expertService.GetSkillById(skillId);
        }

        public List<Skill> GetSkills()
        {
            return _expertService.GetSkills();
        }

        public Category HardDeleteCategory(int categoryId)
        {
            return _expertService.HardDeleteCategory(categoryId);
        }

        public Core.Expert.Entities.Expert HardDeleteExpert(int expertId)
        {
            return _expertService.HardDeleteExpert(expertId);
        }

        public Proposal HardDeleteProposal(int proposalId)
        {
            return _expertService.HardDeleteProposal(proposalId);
        }

        public Service HardDeleteService(int serviceId)
        {
            return _expertService.HardDeleteService(serviceId);
        }

        public Skill HardDeleteSkill(int skillId)
        {
            return _expertService.HardDeleteSkill(skillId);
        }

        public Category SoftDeleteCategory(int categoryId)
        {
            return _expertService.SoftDeleteCategory(categoryId);
        }

        public Core.Expert.Entities.Expert SoftDeleteExpert(int expertId)
        {
            return _expertService.SoftDeleteExpert(expertId);
        }

        public Proposal SoftDeleteProposal(int proposalId)
        {
            return _expertService.SoftDeleteProposal(proposalId);
        }

        public Service SoftDeleteService(int serviceId)
        {
            return _expertService.SoftDeleteService(serviceId);
        }

        public Skill SoftDeleteSkill(int skillId)
        {
            return _expertService.SoftDeleteSkill(skillId);
        }

        public Category UpdateCategory(CategoryDto categoryDto)
        {
            return _expertService.UpdateCategory(categoryDto);
        }

        public Core.Expert.Entities.Expert UpdateExpert(ExpertDto expertDto)
        {
            return _expertService.UpdateExpert(expertDto);
        }

        public Proposal UpdateProposal(ProposalDto proposalDto)
        {
            return _expertService.UpdateProposal(proposalDto);
        }

        public Service UpdateService(ServiceDto serviceDto)
        {
            return _expertService.UpdateService(serviceDto);
        }

        public Skill UpdateSkill(SkillDto skillDto)
        {
            return _expertService.UpdateSkill(skillDto);
        }
    }
}
