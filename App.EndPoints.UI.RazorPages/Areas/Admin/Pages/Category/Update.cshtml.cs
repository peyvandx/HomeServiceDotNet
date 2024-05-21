using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Category
{
    public class UpdateModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;

        public UpdateModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [BindProperty]
        public CategoryDto UpdatingCategory { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingCategory = await _categoryAppService.GetCategoryById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _categoryAppService.UpdateCategory(UpdatingCategory, cancellationToken);
            return RedirectToPage();
        }
    }
}
