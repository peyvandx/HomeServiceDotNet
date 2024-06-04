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

        public async Task<ExpertDto> GetExpertById(int? expertId, CancellationToken cancellationToken)
            => await _expertService.GetExpertById(expertId, cancellationToken);

		public async Task<int?> GetExpertIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
		    => await _expertService.GetExpertIdByApplicationUserId(applicationUserId, cancellationToken);

		public async Task<List<ExpertDto>> GetExperts(CancellationToken cancellationToken)
            => await _expertService.GetExperts(cancellationToken);

        //public async Task<Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        //    => await _expertService.HardDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
            => await _expertService.SoftDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertDto> UpdateExpert(ExpertProfileDto expertProfileDto, CancellationToken cancellationToken)
            => await _expertService.UpdateExpert(expertProfileDto, cancellationToken);

        #endregion
    }
}
