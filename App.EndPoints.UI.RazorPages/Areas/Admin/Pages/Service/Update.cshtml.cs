using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Service
{
    public class UpdateModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;
        private readonly ICategoryAppService _categoryAppService;

        public UpdateModel(IServiceAppService serviceAppService,
            ICategoryAppService categoryAppService)
        {
            _serviceAppService = serviceAppService;
            _categoryAppService = categoryAppService;
        }

        [BindProperty]
        public ServiceDto UpdatingService { get; set; }
        public List<CategoryDto> Categories { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingService = await _serviceAppService.GetServiceById(id, cancellationToken);
            Categories = await _categoryAppService.GetCategories(cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _serviceAppService.UpdateService(UpdatingService, cancellationToken);
            return RedirectToPage();
        }
    }
}
