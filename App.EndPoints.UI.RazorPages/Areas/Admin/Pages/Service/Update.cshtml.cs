using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Service
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;
        private readonly ICategoryAppService _categoryAppService;
        private readonly IBaseAppService _baseAppService;

        public UpdateModel(IServiceAppService serviceAppService,
            ICategoryAppService categoryAppService,
            IBaseAppService baseAppService)
        {
            _serviceAppService = serviceAppService;
            _categoryAppService = categoryAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public ServiceDto UpdatingService { get; set; }
        [BindProperty]
        public IFormFile? ServiceImage { get; set; }
        public List<CategoryDto> Categories { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingService = await _serviceAppService.GetServiceById(id, cancellationToken);
            Categories = await _categoryAppService.GetCategories(cancellationToken);
        }

        public async Task<IActionResult> OnPost(IFormFile? serviceImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }

            if (serviceImage is not null)
            {
                var imageUrl = await _baseAppService.UploadImage(serviceImage);
                UpdatingService.Image = imageUrl;
            }
            await _serviceAppService.UpdateService(UpdatingService, cancellationToken);
            return LocalRedirect("~/Admin/Service/Index");
        }
    }
}
