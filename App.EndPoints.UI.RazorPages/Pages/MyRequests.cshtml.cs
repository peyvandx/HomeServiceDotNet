using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer,Expert")]
    public class MyRequestsModel : PageModel
    {
		private readonly IServiceRequestAppService _serviceRequestAppService;

		public MyRequestsModel(IServiceRequestAppService serviceRequestAppService)
        {
			_serviceRequestAppService = serviceRequestAppService;
		}

        public List<ServiceRequestDto> MyRequests { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userCustomerId").Value);

            MyRequests = await _serviceRequestAppService.GetCustomerServiceRequests(userId, cancellationToken);
        }
    }
}
