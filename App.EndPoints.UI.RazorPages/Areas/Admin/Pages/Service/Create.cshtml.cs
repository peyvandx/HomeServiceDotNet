using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Service
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;
        private readonly IBaseAppService _baseAppService;

        public CreateModel(IServiceAppService serviceAppService,
            IBaseAppService baseAppService)
        {
            _serviceAppService = serviceAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public ServiceDto CreatingService { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "عکس الزامی است")]
        public IFormFile ServiceImage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile serviceImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }

            var imageUrl = await _baseAppService.UploadImage(serviceImage);
            CreatingService.Image = imageUrl;
            await _serviceAppService.CreateService(CreatingService, cancellationToken);
            return LocalRedirect("~/Admin/Service/Index");
        }
    }
}
