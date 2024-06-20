using App.Domain.AppServices.Admin;
using App.Domain.AppServices.Customer;
using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class CommentModel : PageModel
    {
		private readonly ICommentAppService _commentAppService;
		private readonly IExpertAppService _expertAppService;
        private readonly ICustomerAppService _customerAppService;

        public CommentModel(ICommentAppService commentAppService,
            IExpertAppService expertAppService,
            ICustomerAppService customerAppService)
        {
			_commentAppService = commentAppService;
			_expertAppService = expertAppService;
            _customerAppService = customerAppService;
        }

        [BindProperty]
        public CommentDto SubmittedComment { get; set; }
        public ExpertDto Expert { get; set; }
        public List<CommentDto> ExpertComments { get; set; }
        public CommentDto? CustomerComment { get; set; }

        public async Task OnGet(int expertId, ServiceRequestStatus requestStatus, int serviceRequestId, CancellationToken cancellationToken)
        {
            TempData["ServiceRequestId"] = serviceRequestId;
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

            Expert = await _expertAppService.GetExpertById(expertId, cancellationToken);
            ExpertComments = await _commentAppService.GetCommentsByExpertId(expertId, userId.Value, cancellationToken);
            CustomerComment = await _commentAppService.GetCustomerCommentByServiceRequestId(userId.Value, serviceRequestId, cancellationToken);
            TempData["ServiceRequestStatus"] = requestStatus.ToString();
        }

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
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
                SubmittedComment.CustomerId = userId.Value;
            
            await _commentAppService.CreateComment(SubmittedComment, cancellationToken);
            return LocalRedirect("~/MyRequests");
        }
    }
}
