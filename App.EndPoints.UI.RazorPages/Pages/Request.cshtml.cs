using App.Domain.AppServices.Customer;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer,Expert")]
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
            return LocalRedirect("~/Index");
        }
    }
}
