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

		public RequestModel(IServiceAppService serviceAppService,
            IServiceRequestAppService serviceRequestAppService)
        {
			_serviceAppService = serviceAppService;
			_serviceRequestAppService = serviceRequestAppService;
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
            var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userCustomerId").Value);
            ServiceRequest.CustomerId = userId;
			await _serviceRequestAppService.CreateServiceRequest(ServiceRequest, cancellationToken);
            return LocalRedirect("~/Index");
        }
    }
}
