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

        public Task<Core.Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Expert.Entities.Expert> GetExpertById(int expertId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Core.Expert.Entities.Expert>> GetExperts(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Expert.Entities.Expert> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Expert.Entities.Expert> UpdateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
