using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class CommentModel : PageModel
    {
		private readonly ICommentAppService _commentAppService;
		private readonly IExpertAppService _expertAppService;

		public CommentModel(ICommentAppService commentAppService,
            IExpertAppService expertAppService)
        {
			_commentAppService = commentAppService;
			_expertAppService = expertAppService;
		}

        [BindProperty]
        public CommentDto Comment { get; set; }
        public ExpertDto Expert { get; set; }

        public async Task OnGet(int expertId, CancellationToken cancellationToken)
        {
            Expert = await _expertAppService.GetExpertById(expertId, cancellationToken);
        }

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userCustomerId").Value);
            Comment.CustomerId = userId;
            await _commentAppService.CreateComment(Comment, cancellationToken);
            return LocalRedirect("~/Index");
        }
    }
}
