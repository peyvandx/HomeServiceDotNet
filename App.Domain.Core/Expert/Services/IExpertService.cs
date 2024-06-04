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
        public Task<Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken);
        public Task<ExpertDto> UpdateExpert(ExpertProfileDto expertProfileDto, CancellationToken cancellationToken);
        public Task<ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken);
        public Task<ExpertDto> GetExpertById(int? expertId, CancellationToken cancellationToken);
		public Task<int?> GetExpertIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken);
		public Task<List<ExpertDto>> GetExperts(CancellationToken cancellationToken);
    }
}
