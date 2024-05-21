using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Service
{
    public class IndexModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;

        public IndexModel(IServiceAppService serviceAppService)
        {
            _serviceAppService = serviceAppService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _serviceAppService.SoftDeleteService(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
