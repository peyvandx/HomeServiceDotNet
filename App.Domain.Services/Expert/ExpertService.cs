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
        #region Fields
        private readonly IExpertRepository _expertRepository;
        #endregion

        #region Ctors
        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }
        #endregion

        #region Implementations
        public async Task<Core.Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
        {
            var creatingExpert = new Core.Expert.Entities.Expert();
            creatingExpert.SignUpDate = DateTime.Now;
            creatingExpert.FirstName = expertDto.FirstName;
            creatingExpert.LastName = expertDto.LastName;
            creatingExpert.PhoneNumber = expertDto.PhoneNumber;
            creatingExpert.ProfileImage = expertDto.ProfileImage;
            creatingExpert.Age = expertDto.Age;
            return await _expertRepository.CreateExpert(creatingExpert, cancellationToken);
        }

        public async Task<ExpertDto> GetExpertById(int expertId, CancellationToken cancellationToken)
            => await _expertRepository.GetExpertById(expertId, cancellationToken);

        public async Task<List<ExpertDto>> GetExperts(CancellationToken cancellationToken)
            => await _expertRepository.GetExperts(cancellationToken);

        //public async Task<Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        //    => await _expertRepository.HardDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
            => await _expertRepository.SoftDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertDto> UpdateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
        {
            var updatedExpert = new Core.Expert.Entities.Expert();
            updatedExpert.FirstName = expertDto.FirstName;
            updatedExpert.LastName = expertDto.LastName;
            updatedExpert.PhoneNumber = expertDto.PhoneNumber;
            updatedExpert.ProfileImage = expertDto.ProfileImage;
            updatedExpert.Age = expertDto.Age;
            return await _expertRepository.UpdateExpert(updatedExpert, cancellationToken);
        }

        #endregion
    }
}
