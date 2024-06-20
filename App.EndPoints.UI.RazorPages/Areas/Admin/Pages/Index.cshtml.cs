using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages
{
    //[Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
