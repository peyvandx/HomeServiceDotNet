using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _memoryCache;
        #endregion

        #region Ctors
        public ExpertService(IExpertRepository expertRepository,
            IMemoryCache memoryCache)
        {
            _expertRepository = expertRepository;
            _memoryCache = memoryCache;
        }
        #endregion

        #region Implementations
        public async Task<Core.Expert.Entities.Expert> CreateExpert(ExpertDto expertDto, CancellationToken cancellationToken)
        {
            var creatingExpert = new Core.Expert.Entities.Expert();
            creatingExpert.SignUpDate = DateTime.Now;
            creatingExpert.FirstName = expertDto.FirstName;
            creatingExpert.LastName = expertDto.LastName;
            creatingExpert.ProfileImage = expertDto.ProfileImage;
            creatingExpert.Age = expertDto.Age;
            return await _expertRepository.CreateExpert(creatingExpert, cancellationToken);
        }

        public async Task<ExpertDto> GetExpertById(int? expertId, CancellationToken cancellationToken)
            => await _expertRepository.GetExpertById(expertId, cancellationToken);

		public async Task<int?> GetExpertIdByApplicationUserId(int? applicationUserId, CancellationToken cancellationToken)
		    => await _expertRepository.GetExpertIdByApplicationUserId(applicationUserId, cancellationToken);

		public async Task<List<ExpertDto>> GetExperts(CancellationToken cancellationToken)
            => await _expertRepository.GetExperts(cancellationToken);

        //public async Task<Core.Expert.Entities.Expert> HardDeleteExpert(int expertId, CancellationToken cancellationToken)
        //    => await _expertRepository.HardDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertSoftDeleteDto> SoftDeleteExpert(int expertId, CancellationToken cancellationToken)
            => await _expertRepository.SoftDeleteExpert(expertId, cancellationToken);

        public async Task<ExpertDto> UpdateExpert(ExpertProfileDto expertDto, CancellationToken cancellationToken)
        {
            //var updatedExpert = new Core.Expert.Entities.Expert();
            //updatedExpert.Address = new Core.Customer.Entities.Address();
            //updatedExpert.Id = expertDto.Id;
            //updatedExpert.FirstName = expertDto.FirstName;
            //updatedExpert.LastName = expertDto.LastName;
            //updatedExpert.ProfileImage = expertDto.ProfileImageUrl;
            //updatedExpert.Age = expertDto.Age;
            //updatedExpert.AboutMe = expertDto.AboutMe;
            //updatedExpert.FacebookAddress = expertDto.FacebookAddress;
            //updatedExpert.InstagramAddress = expertDto.InstagramAddress;
            //updatedExpert.TwitterAddress = expertDto.TwitterAddress;
            //updatedExpert.LinkedinAddress = expertDto.LinkedinAddress;
            //updatedExpert.Address.Street = expertDto.Address.Street;
            //updatedExpert.Address.PostalCode = expertDto.Address.PostalCode;
            //updatedExpert.Address.CityId = expertDto.Address.CityId;
            _memoryCache.Remove("expertDto");
            return await _expertRepository.UpdateExpert(expertDto, cancellationToken);
        }

        #endregion
    }
}
