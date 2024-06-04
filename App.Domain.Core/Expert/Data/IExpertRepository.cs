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
        public Task<Expert.Entities.Expert> CreateExpert(Expert.Entities.Expert signingUpExpert, CancellationToken cancellationToken);
        public Task<ExpertDto> UpdateExpert(ExpertProfileDto updatedExpert, CancellationToken cancellationToken);
        public Task<ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken);
        public Task<ExpertDto> GetExpertById(int? expertId, CancellationToken cancellationToken);
		public Task<int?> GetExpertIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken);
		public Task<List<ExpertDto>> GetExperts(CancellationToken cancellationToken);
    }
}
