using App.Domain.AppServices.Expert;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Expert")]
    public class MyProposalsModel : PageModel
    {
        private readonly IProposalAppService _proposalAppService;
        private readonly IExpertAppService _expertAppService;

        public MyProposalsModel(IProposalAppService proposalAppService,
            IExpertAppService expertAppService)
        {
            _proposalAppService = proposalAppService;
            _expertAppService = expertAppService;
        }

        public List<ProposalDto> MyProposals { get; set; }

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

            MyProposals = await _proposalAppService.GetProposalsByExpertId(userId, cancellationToken);
        }

        public async Task<IActionResult> OnPostCancell(int proposalId, CancellationToken cancellationToken)
        {
            await _proposalAppService.SoftDeleteProposal(proposalId, cancellationToken);
            return LocalRedirect("~/MyProposals");
        }

        public async Task<IActionResult> OnPostDelete(int proposalId, CancellationToken cancellationToken)
        {
            await _proposalAppService.SoftDeleteProposal(proposalId, cancellationToken);
            return LocalRedirect("~/MyProposals");
        }
    }
}
