using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Comment
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ICommentAppService _commentAppService;

        public IndexModel(ICommentAppService commentAppService)
        {
            _commentAppService = commentAppService;
        }

        public List<CommentDto> Comments { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            Comments = await _commentAppService.GetComments(cancellationToken);
        }

        public async Task<IActionResult> OnGetActive(int commentId, CancellationToken cancellationToken)
        {
            await _commentAppService.ConfirmComment(commentId, cancellationToken);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetDelete(int commentId, CancellationToken cancellationToken)
        {
            await _commentAppService.SoftDeleteComment(commentId, cancellationToken);
            return RedirectToPage();
        }

    }
}
