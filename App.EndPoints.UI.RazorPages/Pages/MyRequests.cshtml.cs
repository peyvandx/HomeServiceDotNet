using App.Domain.AppServices.Customer;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer")]
    public class MyRequestsModel : PageModel
    {
		private readonly IServiceRequestAppService _serviceRequestAppService;
		private readonly ICustomerAppService _customerAppService;

		public MyRequestsModel(IServiceRequestAppService serviceRequestAppService,
			ICustomerAppService customerAppService)
        {
			_serviceRequestAppService = serviceRequestAppService;
			_customerAppService = customerAppService;
		}

        public List<ServiceRequestDto> MyRequests { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
			var applicationUserId = int.Parse(User.Claims.First().Value);
			int? userId;

			var user = User.Claims.FirstOrDefault(c => c.Type == "userCustomerId");
			if (user is not null)
			{
				userId = int.Parse(user.Value);
			}
			else
			{
				userId = await _customerAppService.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);
			}

			MyRequests = await _serviceRequestAppService.GetCustomerServiceRequests(userId, cancellationToken);
        }

		public async Task<IActionResult> OnPostDelete(int requestId, CancellationToken cancellationToken)
		{
			await _serviceRequestAppService.SoftDeleteServiceRequest(requestId, cancellationToken);
			//change this request proposals status to 'cancelled from customer'!!!
			return LocalRedirect("~/MyRequests");
		}
    }
}
