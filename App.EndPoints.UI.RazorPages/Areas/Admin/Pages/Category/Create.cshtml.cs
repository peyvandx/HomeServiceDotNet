using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Category
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly IBaseAppService _baseAppService;

        public CreateModel(ICategoryAppService categoryAppService,
            IBaseAppService baseAppService)
        {
            _categoryAppService = categoryAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public CategoryDto CreatingCategory { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "عکس الزامی است")]
        public IFormFile CategoryImage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile categoryImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }

            var imageUrl = await _baseAppService.UploadImage(categoryImage);
            CreatingCategory.Image = imageUrl;
            await _categoryAppService.CreateCategory(CreatingCategory, cancellationToken);
            return LocalRedirect("~/Admin/Category/Index");

        }
    }
}
