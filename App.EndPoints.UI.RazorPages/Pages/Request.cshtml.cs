using App.Domain.AppServices.Customer;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    //[Authorize(Roles = "Customer")]
    public class RequestModel : PageModel
    {
		private readonly IServiceAppService _serviceAppService;
		private readonly IServiceRequestAppService _serviceRequestAppService;
        private readonly ICustomerAppService _customerAppService;

        public RequestModel(IServiceAppService serviceAppService,
            IServiceRequestAppService serviceRequestAppService,
            ICustomerAppService customerAppService)
        {
			_serviceAppService = serviceAppService;
			_serviceRequestAppService = serviceRequestAppService;
            _customerAppService = customerAppService;
        }

        [BindProperty]
        public ServiceRequestDto ServiceRequest { get; set; }
        public ServiceDto SelectedService { get; set; }

        public async Task OnGet(int serviceId, CancellationToken cancellationToken)
        {
            SelectedService = await _serviceAppService.GetServiceById(serviceId, cancellationToken);
        }

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("OnGet", new { serviceId = ServiceRequest.ServiceId });
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }
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

            ServiceRequest.CustomerId = userId.Value;
			await _serviceRequestAppService.CreateServiceRequest(ServiceRequest, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }
    }
}
