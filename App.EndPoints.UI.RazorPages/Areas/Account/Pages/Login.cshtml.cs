using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Account.Pages
{
    public class LoginModel : PageModel
    {

        private readonly IAccountAppService _accountAppService;

        public LoginModel(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        [BindProperty]
        public LoginDto Input { get; set; }


        //public class InputModel
        //{
        //    [Required]
        //    public string Email { get; set; }

        //    [Required]
        //    public string Password { get; set; }

        //}



        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (!ModelState.IsValid) return Page();

            var succeededLogin = await _accountAppService.Login(Input);

            if (succeededLogin)
                return LocalRedirect(returnUrl);

            else
            {
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است");
                return Page();
            }

        }

    }
}
