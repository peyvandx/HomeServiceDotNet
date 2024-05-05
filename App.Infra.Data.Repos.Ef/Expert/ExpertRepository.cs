using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class ExpertRepository : IExpertRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public ExpertRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion
        #region Implementations

        public async Task<Domain.Core.Expert.Entities.Expert> CreateExpert(Domain.Core.Expert.Entities.Expert signingUpExpert, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Experts.AddAsync(signingUpExpert, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return signingUpExpert;
        }

        public async Task<Domain.Core.Expert.Entities.Expert> GetExpertById(int expertId, CancellationToken cancellationToken)
        {
            var expert = await _homeServiceDbContext.Experts.FirstOrDefaultAsync(e => e.Id == expertId, cancellationToken);
            if (expert != null)
            {
                return expert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Domain.Core.Expert.Entities.Expert>> GetExperts(CancellationToken cancellationToken) => await _homeServiceDbContext.Experts.ToListAsync(cancellationToken);
        //{
        //    var experts = await _homeServiceDbContext.Experts.ToListAsync(cancellationToken);
        //    if (experts != null)
        //    {
        //        return experts;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Domain.Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        {
            var deletedExpert = await GetExpert(expertId, cancellationToken);
            if (deletedExpert != null)
            {
                deletedExpert.IsDeleted = true;
                _homeServiceDbContext.Experts.Remove(deletedExpert);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Domain.Core.Expert.Entities.Expert> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
        {
            var deletedExpert = await GetExpert(expertId, cancellationToken);
            if (deletedExpert != null)
            {
                deletedExpert.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Domain.Core.Expert.Entities.Expert> UpdateExpert(Domain.Core.Expert.Entities.Expert updatedExpert, CancellationToken cancellationToken)
        {
            var updatingExpert = await GetExpert(updatedExpert.Id, cancellationToken);
            if (updatingExpert != null)
            {
                updatingExpert.FirstName = updatedExpert.FirstName;
                updatingExpert.LastName = updatedExpert.LastName;
                updatingExpert.PhoneNumber = updatedExpert.PhoneNumber;
                updatingExpert.ProfileImage = updatedExpert.ProfileImage;
                updatingExpert.Age = updatedExpert.Age;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingExpert;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.Entities.Expert> GetExpert(int expertId, CancellationToken cancellationToken)
        {
            var expert = await _homeServiceDbContext.Experts
                .FirstOrDefaultAsync(a => a.Id == expertId, cancellationToken);

            if (expert != null)
            {
                return expert;
            }

            throw new Exception($"admin with id {expertId} not found");
        }
        #endregion
    }
}
