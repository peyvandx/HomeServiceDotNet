using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServiceController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly IServiceRequestAppService _serviceRequestAppService;
        private readonly IAccountAppService _accountAppService;

        public HomeServiceController(ICategoryAppService categoryAppService,
            IServiceRequestAppService serviceRequestAppService,
            IAccountAppService accountAppService)
        {
            _categoryAppService = categoryAppService;
            _serviceRequestAppService = serviceRequestAppService;
            _accountAppService = accountAppService;
        }

        [HttpGet]
        [Route(nameof(GetCategoriesWithServices))]
        public async Task<List<CategoryDto>> GetCategoriesWithServices(CancellationToken cancellationToken)
            => await _categoryAppService.GetCategoriesWithServices(cancellationToken);

        [HttpGet]
        [Route(nameof(GetServiceRequests))]
        public async Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken)
            => await _serviceRequestAppService.GetServiceRequests(cancellationToken);

        [HttpPost]
        [Route(nameof(RegisterUser))]
        public async Task<string> RegisterUser(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            var resultErrors = await _accountAppService.Register(registerDto);
            if (resultErrors.Count == 0)
                return "Success";
            else
                return "Failed";
        }
    }
}
