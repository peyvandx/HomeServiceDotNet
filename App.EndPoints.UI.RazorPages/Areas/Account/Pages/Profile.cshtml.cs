
using App.Domain.Core.Admin.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Account.Pages
{
    [Authorize(Roles = "Visitor,Reporter")]
    public class ProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IReporterAppServices _reporterAppServices;

        //[BindProperty]
        //public ReporterSummeryDto ReporterSummery { get; set; }
        //IReporterAppServices reporterAppServices
        public ProfileModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            //_reporterAppServices = reporterAppServices;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.Claims.First().Value);

            if (User.IsInRole("Visitor"))
            {

            }

            if (User.IsInRole("Reporter"))
            {
                //ReporterSummery = await _reporterAppServices.GetSummery(userId, cancellationToken);
            }
        }
    }
}
