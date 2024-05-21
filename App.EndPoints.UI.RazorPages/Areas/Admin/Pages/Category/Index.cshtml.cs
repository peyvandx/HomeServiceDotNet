using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;

        public IndexModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _categoryAppService.SoftDeleteCategory(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
