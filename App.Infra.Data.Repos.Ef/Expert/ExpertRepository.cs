using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
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
        public void CreateCategory(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public void CreateExpert(ExpertDto expertDto)
        {
            throw new NotImplementedException();
        }

        public void CreateProposal(ProposalDto proposalDto)
        {
            throw new NotImplementedException();
        }

        public void CreateService(ServiceDto serviceDto)
        {
            throw new NotImplementedException();
        }

        public void CreateSkill(SkillDto skillDto)
        {
            throw new NotImplementedException();
        }

        public void GetCategories()
        {
            throw new NotImplementedException();
        }

        public void GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetExpertById(int expertId)
        {
            throw new NotImplementedException();
        }

        public void GetExperts()
        {
            throw new NotImplementedException();
        }

        public void GetProposalById(int proposalId)
        {
            throw new NotImplementedException();
        }

        public void GetProposals()
        {
            throw new NotImplementedException();
        }

        public void GetServiceById(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void GetServices()
        {
            throw new NotImplementedException();
        }

        public void GetSkillById(int skillId)
        {
            throw new NotImplementedException();
        }

        public void GetSkills()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteExpert(int expertId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteProposal(int proposalId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteService(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteSkill(int skillId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteExpert(int expertId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteProposal(int proposalId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteService(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteSkill(int skillId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpert(ExpertDto expertDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProposal(ProposalDto proposalDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(ServiceDto serviceDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkill(SkillDto skillDto)
        {
            throw new NotImplementedException();
        }
    }
}
