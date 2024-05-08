using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.AppServices
{
    public interface IExpertAppService
    {
        public Task<Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Expert> UpdateExpert(ExpertDto expertDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Expert> SoftDeleteExpert(int expertId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Expert> GetExpertById(int expertId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Expert>> GetExperts(CancellationToken cancellationToken);
    }
}
