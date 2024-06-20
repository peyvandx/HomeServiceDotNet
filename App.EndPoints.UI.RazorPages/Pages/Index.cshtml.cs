using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;

        public IndexModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        public List<CategoryDto> Categories { get; set; }

        public async Task<IActionResult> OnGet(CancellationToken cancellationToken)
        {
            if (User.IsInRole("Admin"))
                return LocalRedirect("/Admin/Index");

            Categories = await _categoryAppService.GetCategories(cancellationToken);
            return null;
        }
    }
}
