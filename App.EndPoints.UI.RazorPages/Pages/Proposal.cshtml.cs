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
	public class ProposalModel : PageModel
    {
		private readonly IProposalAppService _proposalAppService;
		private readonly IServiceRequestAppService _serviceRequestAppService;
		private readonly IExpertAppService _expertAppService;

		public ProposalModel(IProposalAppService proposalAppService,
            IServiceRequestAppService serviceRequestAppService,
			IExpertAppService expertAppService)
        {
			_proposalAppService = proposalAppService;
			_serviceRequestAppService = serviceRequestAppService;
			_expertAppService = expertAppService;
		}

        [BindProperty]
        public ProposalDto Proposal { get; set; }
        public ServiceRequestDto ServiceRequest { get; set; }

        public async Task OnGet(int serviceRequestId, CancellationToken cancellationToken)
        {
            ServiceRequest = await _serviceRequestAppService.GetServiceRequestById(serviceRequestId, cancellationToken);
        }

        public async Task<IActionResult> OnPostSendProposal(CancellationToken cancellationToken)
        {
			if (!ModelState.IsValid)
			{
				return RedirectToAction("OnGet", new { serviceRequestId = Proposal.ServiceRequestId });
				//return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
			}
			var applicationUserId = int.Parse(User.Claims.First().Value);
			//check profile page line 75
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
			Proposal.ExpertId = userId;
			await _proposalAppService.CreateProposal(Proposal, cancellationToken);
			return LocalRedirect("~/Requests");
        }
    }
}
