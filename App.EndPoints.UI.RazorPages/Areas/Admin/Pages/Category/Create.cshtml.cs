using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;

        public CreateModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [BindProperty]
        public CategoryDto CreatingCategory { get; set; }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _categoryAppService.CreateCategory(CreatingCategory, cancellationToken);
            return RedirectToPage();
        }
    }
}
