using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly HomeServiceDbContext _homeServiceDbContext;

        public ExpertRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }

        public Category CreateCategory(Category createdCategory)
        {
            _homeServiceDbContext.Categories.Add(createdCategory);
            _homeServiceDbContext.SaveChanges();
            return createdCategory;
        }

        public Domain.Core.Expert.Entities.Expert CreateExpert(Domain.Core.Expert.Entities.Expert signingUpExpert)
        {
            _homeServiceDbContext.Experts.Add(signingUpExpert);
            _homeServiceDbContext.SaveChanges();
            return signingUpExpert;
        }

        public Proposal CreateProposal(Proposal submittedProposal)
        {
            _homeServiceDbContext.Proposals.Add(submittedProposal);
            _homeServiceDbContext.SaveChanges();
            return submittedProposal;
        }

        public Service CreateService(Service createdService)
        {
            _homeServiceDbContext.Services.Add(createdService);
            _homeServiceDbContext.SaveChanges();
            return createdService;
        }

        public Skill CreateSkill(Skill submittedSkill)
        {
            _homeServiceDbContext.Skills.Add(submittedSkill);
            _homeServiceDbContext.SaveChanges();
            return submittedSkill;
        }

        public List<Category> GetCategories()
        {
            return _homeServiceDbContext.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _homeServiceDbContext.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public Domain.Core.Expert.Entities.Expert GetExpertById(int expertId)
        {
            return _homeServiceDbContext.Experts.FirstOrDefault(e => e.Id == expertId);
        }

        public List<Domain.Core.Expert.Entities.Expert> GetExperts()
        {
            return _homeServiceDbContext.Experts.ToList();
        }

        public Proposal GetProposalById(int proposalId)
        {
            return _homeServiceDbContext.Proposals.FirstOrDefault(p => p.Id == proposalId);
        }

        public List<Proposal> GetProposals()
        {
            return _homeServiceDbContext.Proposals.ToList();
        }

        public Service GetServiceById(int serviceId)
        {
            return _homeServiceDbContext.Services.FirstOrDefault(s => s.Id == serviceId);
        }

        public List<Service> GetServices()
        {
            return _homeServiceDbContext.Services.ToList();
        }

        public Skill GetSkillById(int skillId)
        {
            return _homeServiceDbContext.Skills.FirstOrDefault(s => s.Id == skillId);
        }

        public List<Skill> GetSkills()
        {
            return _homeServiceDbContext.Skills.ToList();
        }

        public Category HardDeleteCategory(int categoryId)
        {
            var deletedCategory = GetCategoryById(categoryId);
            if (deletedCategory != null)
            {
                deletedCategory.IsDeleted = true;
                _homeServiceDbContext.Categories.Remove(deletedCategory);
                _homeServiceDbContext.SaveChanges();
                return deletedCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Expert.Entities.Expert HardDeleteExpert(int expertId)
        {
            var deletedExpert = GetExpertById(expertId);
            if (deletedExpert != null)
            {
                deletedExpert.IsDeleted = true;
                _homeServiceDbContext.Experts.Remove(deletedExpert);
                _homeServiceDbContext.SaveChanges();
                return deletedExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Proposal HardDeleteProposal(int proposalId)
        {
            var deletedProposal = GetProposalById(proposalId);
            if (deletedProposal != null)
            {
                deletedProposal.IsDeleted = true;
                _homeServiceDbContext.Proposals.Remove(deletedProposal);
                _homeServiceDbContext.SaveChanges();
                return deletedProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Service HardDeleteService(int serviceId)
        {
            var deletedService = GetServiceById(serviceId);
            if (deletedService != null)
            {
                deletedService.IsDeleted = true;
                _homeServiceDbContext.Services.Remove(deletedService);
                _homeServiceDbContext.SaveChanges();
                return deletedService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Skill HardDeleteSkill(int skillId)
        {
            var deletedSkill = GetSkillById(skillId);
            if (deletedSkill != null)
            {
                deletedSkill.IsDeleted = true;
                _homeServiceDbContext.Skills.Remove(deletedSkill);
                _homeServiceDbContext.SaveChanges();
                return deletedSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Category SoftDeleteCategory(int categoryId)
        {
            var deletedCategory = GetCategoryById(categoryId);
            if (deletedCategory != null)
            {
                deletedCategory.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Expert.Entities.Expert SoftDeleteExpert(int expertId)
        {
            var deletedExpert = GetExpertById(expertId);
            if (deletedExpert != null)
            {
                deletedExpert.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Proposal SoftDeleteProposal(int proposalId)
        {
            var deletedProposal = GetProposalById(proposalId);
            if (deletedProposal != null)
            {
                deletedProposal.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Service SoftDeleteService(int serviceId)
        {
            var deletedService = GetServiceById(serviceId);
            if (deletedService != null)
            {
                deletedService.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Skill SoftDeleteSkill(int skillId)
        {
            var deletedSkill = GetSkillById(skillId);
            if (deletedSkill != null)
            {
                deletedSkill.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Category UpdateCategory(Category updatedCategory)
        {
            var updatingCategory = GetCategoryById(updatedCategory.Id);
            if (updatingCategory != null)
            {
                updatingCategory.Title = updatedCategory.Title;
                updatingCategory.Description = updatedCategory.Description;
                updatingCategory.Image = updatedCategory.Image;
                _homeServiceDbContext.SaveChanges();
                return updatingCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Expert.Entities.Expert UpdateExpert(Domain.Core.Expert.Entities.Expert updatedExpert)
        {
            var updatingExpert = GetExpertById(updatedExpert.Id);
            if (updatingExpert != null)
            {
                updatingExpert.FirstName = updatedExpert.FirstName;
                updatingExpert.LastName = updatedExpert.LastName;
                updatingExpert.PhoneNumber = updatedExpert.PhoneNumber;
                updatingExpert.ProfileImage = updatedExpert.ProfileImage;
                updatingExpert.Age = updatedExpert.Age;
                _homeServiceDbContext.SaveChanges();
                return updatingExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Proposal UpdateProposal(Proposal updatedProposal)
        {
            var updatingProposal = GetProposalById(updatedProposal.Id);
            if (updatingProposal != null)
            {
                updatingProposal.ExpertDescription = updatedProposal.ExpertDescription;
                updatingProposal.SuggestedPrice = updatedProposal.SuggestedPrice;
                _homeServiceDbContext.SaveChanges();
                return updatingProposal;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Service UpdateService(Service updatedService)
        {
            var updatingService = GetServiceById(updatedService.Id);
            if (updatingService != null)
            {
                updatingService.Title = updatedService.Title;
                updatingService.Description = updatedService.Description;
                updatingService.Image = updatedService.Image;
                updatingService.WorkExperience = updatedService.WorkExperience;
                _homeServiceDbContext.SaveChanges();
                return updatingService;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Skill UpdateSkill(Skill updatedSkill)
        {
            var updatingSkill = GetSkillById(updatedSkill.Id);
            if (updatingSkill != null)
            {
                updatingSkill.Title = updatedSkill.Title;
                updatingSkill.Description = updatedSkill.Description;
                updatingSkill.SelfRate = updatedSkill.SelfRate;
                _homeServiceDbContext.SaveChanges();
                return updatingSkill;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
    }
}
