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
        public List<ProposalDto> Suggestions { get; set; }

        public async Task OnGet(int serviceRequestId, CancellationToken cancellationToken)
        {
            ViewData["serviceRequestId"] = serviceRequestId;
            Suggestions = await _proposalAppService.GetProposalsByServiceRequestId(serviceRequestId, cancellationToken);
        }

        public async Task<IActionResult> OnPostAcceptAsync(int proposalId, CancellationToken cancellationToken)
        {
            //await _proposalAppService.AcceptProposal(proposalId, cancellationToken).ConfigureAwait(false);
            await _proposalAppService.AcceptProposal(proposalId, cancellationToken);
            await _serviceRequestAppService.ChangeServiceRequestStatus(ServiceRequestNewStatus, cancellationToken);
            return LocalRedirect("~/Index");
        }

        public async Task<IActionResult> OnPostRejectAsync(int proposalId, CancellationToken cancellationToken)
        {
            //await _proposalAppService.AcceptProposal(proposalId, cancellationToken).ConfigureAwait(false);
            await _proposalAppService.RejectProposal(proposalId, cancellationToken);
            return LocalRedirect("~/Index");
        }
    }
}
