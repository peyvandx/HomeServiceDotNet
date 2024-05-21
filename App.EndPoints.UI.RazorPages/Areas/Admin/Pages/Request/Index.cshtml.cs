using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.ServiceRequest
{
    public class IndexModel : PageModel
    {
        private readonly IServiceRequestAppService _serviceRequestAppService;

        public IndexModel(IServiceRequestAppService serviceRequestAppService)
        {
            _serviceRequestAppService = serviceRequestAppService;
        }

        [BindProperty]
        public ServiceRequestChangeStatusDto ServiceRequestChangeStatus { get; set; }
        public List<ServiceRequestDto> ServiceRequests { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            ServiceRequests = await _serviceRequestAppService.GetServiceRequests(cancellationToken);
        }

        public async Task OnGetChangeStatus(CancellationToken cancellationToken)
        {
            await _serviceRequestAppService.ChangeServiceRequestStatus(ServiceRequestChangeStatus, cancellationToken);
        }

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _serviceRequestAppService.SoftDeleteServiceRequest(id, cancellationToken);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _serviceRequestAppService.ChangeServiceRequestStatus(ServiceRequestChangeStatus, cancellationToken);
            return RedirectToPage();
        }
    }
}
