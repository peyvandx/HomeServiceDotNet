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
        #region Fields
        private readonly IExpertService _expertService;
        #endregion

        #region Ctors
        public ExpertAppService(IExpertService expertService)
        {
            _expertService = expertService;
        }
        #endregion

        #region Implementations
        public async Task<Core.Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
            => await _expertService.CreateExpert(expertDto, cancellationToken);

        public async Task<Core.Expert.Entities.Expert> GetExpertById(int expertId, CancellationToken cancellationToken)
            => await _expertService.GetExpertById(expertId, cancellationToken);

        public async Task<List<Core.Expert.Entities.Expert>> GetExperts(CancellationToken cancellationToken)
            => await _expertService.GetExperts(cancellationToken);

        public async Task<Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
            => await _expertService.HardDeleteExpert(expertId, cancellationToken);

        public async Task<Core.Expert.Entities.Expert> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
            => await _expertService.SoftDeleteExpert(expertId, cancellationToken);

        public async Task<Core.Expert.Entities.Expert> UpdateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
            => await _expertService.UpdateExpert(expertDto, cancellationToken);

        #endregion
    }
}
