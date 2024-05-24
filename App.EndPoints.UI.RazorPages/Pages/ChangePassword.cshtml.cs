using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer,Expert")]
    public class ChangePasswordModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
