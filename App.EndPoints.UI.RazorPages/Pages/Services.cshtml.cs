using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class ServicesModel : PageModel
    {
		private readonly IServiceAppService _serviceAppService;

		public ServicesModel(IServiceAppService serviceAppService)
        {
			_serviceAppService = serviceAppService;
		}

        public List<ServiceDto> Services { get; set; }

        public async Task OnGet(int categoryId, CancellationToken cancellationToken)
        {
            Services = await _serviceAppService.GetServicesByCategoryId(categoryId, cancellationToken);
        }
    }
}
