using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Services;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Category
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly IBaseAppService _baseAppService;

        public UpdateModel(ICategoryAppService categoryAppService,
            IBaseAppService baseAppService)
        {
            _categoryAppService = categoryAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public CategoryDto UpdatingCategory { get; set; }

        [BindProperty]
        public IFormFile? CategoryImage { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingCategory = await _categoryAppService.GetCategoryById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(IFormFile? categoryImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }

            if (categoryImage is not null)
            {
                var imageUrl = await _baseAppService.UploadImage(categoryImage);
                UpdatingCategory.Image = imageUrl;
            }
            await _categoryAppService.UpdateCategory(UpdatingCategory, cancellationToken);
            return LocalRedirect("~/Admin/Category/Index");
        }
    }
}
