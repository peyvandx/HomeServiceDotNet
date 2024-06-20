using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer")]
    public class SuggestionsModel : PageModel
    {
        private readonly IProposalAppService _proposalAppService;
        private readonly IServiceRequestAppService _serviceRequestAppService;

        public SuggestionsModel(IProposalAppService proposalAppService,
            IServiceRequestAppService serviceRequestAppService)
        {
            _proposalAppService = proposalAppService;
            _serviceRequestAppService = serviceRequestAppService;
        }

        [BindProperty]
        public ServiceRequestChangeStatusDto ServiceRequestNewStatus { get; set; }
        [BindProperty]
        public ProposalConfirmationDto ConfirmedProposal{ get; set; }
        [BindProperty]
        public RequestProposalIdsDto ServiceRequestProposalIds { get; set; }
        public List<ProposalDto> Suggestions { get; set; }

        public async Task OnGet(int serviceRequestId, CancellationToken cancellationToken)
        {
            //ViewData["serviceRequestId"] = serviceRequestId;
            Suggestions = await _proposalAppService.GetProposalsByServiceRequestId(serviceRequestId, cancellationToken);
        }

        public async Task<IActionResult> OnPostAcceptAsync(CancellationToken cancellationToken)
        {
            await _proposalAppService.AcceptProposal(ConfirmedProposal, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }

        public async Task<IActionResult> OnPostRejectAsync(int proposalId, CancellationToken cancellationToken)
        {
            await _proposalAppService.RejectProposal(proposalId, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }

        public async Task<IActionResult> OnPostSuccessful(CancellationToken cancellationToken)
        {
            await _serviceRequestAppService.ServiceRequestDoneSuccessfully(ServiceRequestProposalIds, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }

        public async Task<IActionResult> OnPostUnsuccessful(CancellationToken cancellationToken)
        {
            await _serviceRequestAppService.ServiceRequestDoneUnSuccessfully(ServiceRequestProposalIds, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }
    }
}
