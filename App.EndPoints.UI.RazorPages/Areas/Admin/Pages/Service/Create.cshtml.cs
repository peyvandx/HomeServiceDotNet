using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Service
{
    public class CreateModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;

        public CreateModel(IServiceAppService serviceAppService)
        {
            _serviceAppService = serviceAppService;
        }

        [BindProperty]
        public ServiceDto CreatingService { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _serviceAppService.CreateService(CreatingService, cancellationToken);
            return RedirectToPage();
        }
    }
}
