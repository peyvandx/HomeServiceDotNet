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
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;

        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }

        public Category CreateCategory(CategoryDto categoryDto)
        {
            var creatingCategory = new Category();
            creatingCategory.CreatedAt = DateTime.Now;
            creatingCategory.Title = categoryDto.Title;
            creatingCategory.Description = categoryDto.Description;
            creatingCategory.Image = categoryDto.Image;
            return _expertRepository.CreateCategory(creatingCategory);
        }

        public Core.Expert.Entities.Expert CreateExpert(ExpertDto expertDto)
        {
            var creatingExpert = new Core.Expert.Entities.Expert();
            creatingExpert.SignUpDate = DateTime.Now;
            creatingExpert.FirstName = expertDto.FirstName;
            creatingExpert.LastName = expertDto.LastName;
            creatingExpert.PhoneNumber = expertDto.PhoneNumber;
            creatingExpert.ProfileImage = expertDto.ProfileImage;
            creatingExpert.Age = expertDto.Age;
            return _expertRepository.CreateExpert(creatingExpert);
        }

        public Proposal CreateProposal(ProposalDto proposalDto)
        {
            var creatingProposal = new Proposal();
            creatingProposal.CreatedAt = DateTime.Now;
            creatingProposal.ExpertDescription = proposalDto.ExpertDescription;
            creatingProposal.SuggestedPrice = proposalDto.SuggestedPrice;
            creatingProposal.ExpertId = proposalDto.ExpertId;
            creatingProposal.ServiceRequestId = proposalDto.ServiceRequestId;
            return _expertRepository.CreateProposal(creatingProposal);
        }

        public Service CreateService(ServiceDto serviceDto)
        {
            var creatingSevice = new Service();
            creatingSevice.CreatedAt = DateTime.Now;
            creatingSevice.Title = serviceDto.Title;
            creatingSevice.Description = serviceDto.Description;
            creatingSevice.Image = serviceDto.Image;
            creatingSevice.WorkExperience = serviceDto.WorkExperience;
            creatingSevice.CategoryId = serviceDto.CategoryId;
            return _expertRepository.CreateService(creatingSevice);
        }

        public Skill CreateSkill(SkillDto skillDto)
        {
            var creatingSkill = new Skill();
            creatingSkill.CreatedAt = DateTime.Now;
            creatingSkill.Title = skillDto.Title;
            creatingSkill.Description = skillDto.Description;
            creatingSkill.SelfRate = skillDto.SelfRate;
            creatingSkill.ExpertId = skillDto.ExpertId;
            return _expertRepository.CreateSkill(creatingSkill);
        }

        public List<Category> GetCategories()
        {
            return _expertRepository.GetCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _expertRepository.GetCategoryById(categoryId);
        }

        public Core.Expert.Entities.Expert GetExpertById(int expertId)
        {
            return _expertRepository.GetExpertById(expertId);
        }

        public List<Core.Expert.Entities.Expert> GetExperts()
        {
            return _expertRepository.GetExperts();
        }

        public Proposal GetProposalById(int proposalId)
        {
            return _expertRepository.GetProposalById(proposalId);
        }

        public List<Proposal> GetProposals()
        {
            return _expertRepository.GetProposals();
        }

        public Service GetServiceById(int serviceId)
        {
            return _expertRepository.GetServiceById(serviceId);
        }

        public List<Service> GetServices()
        {
            return _expertRepository.GetServices();
        }

        public Skill GetSkillById(int skillId)
        {
            return _expertRepository.GetSkillById(skillId);
        }

        public List<Skill> GetSkills()
        {
            return _expertRepository.GetSkills();
        }

        public Category HardDeleteCategory(int categoryId)
        {
            return _expertRepository.HardDeleteCategory(categoryId);
        }

        public Core.Expert.Entities.Expert HardDeleteExpert(int expertId)
        {
            return _expertRepository.HardDeleteExpert(expertId);
        }

        public Proposal HardDeleteProposal(int proposalId)
        {
            return _expertRepository.HardDeleteProposal(proposalId);
        }

        public Service HardDeleteService(int serviceId)
        {
            return _expertRepository.HardDeleteService(serviceId);
        }

        public Skill HardDeleteSkill(int skillId)
        {
            return _expertRepository.HardDeleteSkill(skillId);
        }

        public Category SoftDeleteCategory(int categoryId)
        {
            return _expertRepository.SoftDeleteCategory(categoryId);
        }

        public Core.Expert.Entities.Expert SoftDeleteExpert(int expertId)
        {
            return _expertRepository.SoftDeleteExpert(expertId);
        }

        public Proposal SoftDeleteProposal(int proposalId)
        {
            return _expertRepository.SoftDeleteProposal(proposalId);
        }

        public Service SoftDeleteService(int serviceId)
        {
            return _expertRepository.SoftDeleteService(serviceId);
        }

        public Skill SoftDeleteSkill(int skillId)
        {
            return _expertRepository.SoftDeleteSkill(skillId);
        }

        public Category UpdateCategory(CategoryDto categoryDto)
        {
            var updatedCategory = new Category();
            updatedCategory.Title = categoryDto.Title;
            updatedCategory.Description = categoryDto.Description;
            updatedCategory.Image = categoryDto.Image;
            return _expertRepository.UpdateCategory(updatedCategory);
        }

        public Core.Expert.Entities.Expert UpdateExpert(ExpertDto expertDto)
        {
            var updatedExpert = new Core.Expert.Entities.Expert();
            updatedExpert.FirstName = expertDto.FirstName;
            updatedExpert.LastName = expertDto.LastName;
            updatedExpert.PhoneNumber = expertDto.PhoneNumber;
            updatedExpert.ProfileImage = expertDto.ProfileImage;
            updatedExpert.Age = expertDto.Age;
            return _expertRepository.UpdateExpert(updatedExpert);
        }

        public Proposal UpdateProposal(ProposalDto proposalDto)
        {
            var updatedProposal = new Proposal();
            updatedProposal.ExpertDescription = proposalDto.ExpertDescription;
            updatedProposal.SuggestedPrice = proposalDto.SuggestedPrice;
            return _expertRepository.UpdateProposal(updatedProposal);
        }

        public Service UpdateService(ServiceDto serviceDto)
        {
            var updatedService = new Service();
            updatedService.Title = serviceDto.Title;
            updatedService.Description = serviceDto.Description;
            updatedService.Image = serviceDto.Image;
            updatedService.WorkExperience = serviceDto.WorkExperience;
            return _expertRepository.UpdateService(updatedService);
        }

        public Skill UpdateSkill(SkillDto skillDto)
        {
            var updatedSkill = new Skill();
            updatedSkill.Title = skillDto.Title;
            updatedSkill.Description = skillDto.Description;
            updatedSkill.SelfRate = skillDto.SelfRate;
            return _expertRepository.UpdateSkill(updatedSkill);
        }
    }
}
