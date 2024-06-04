using App.Domain.AppServices.Expert;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Expert")]
    public class RequestsModel : PageModel
    {
        private readonly IServiceRequestAppService _serviceRequestAppService;
        private readonly IExpertAppService _expertAppService;

        public RequestsModel(IServiceRequestAppService serviceRequestAppService,
            IExpertAppService expertAppService)
        {
            _serviceRequestAppService = serviceRequestAppService;
            _expertAppService = expertAppService;
        }

        public List<ServiceRequestDto> Requests { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var applicationUserId = int.Parse(User.Claims.First().Value);
            int? userId;
            var user = User.Claims.FirstOrDefault(c => c.Type == "userExpertId");
            if (user is not null)
            {
                userId = int.Parse(user.Value);
            }
            else
            {
                userId = await _expertAppService.GetExpertIdByApplicationUserId(applicationUserId, cancellationToken);
            }

            TempData["UserId"] = userId;
            Requests = await _serviceRequestAppService.GetExpertRelatedServiceRequests(userId.Value, cancellationToken);
        }
    }
}
