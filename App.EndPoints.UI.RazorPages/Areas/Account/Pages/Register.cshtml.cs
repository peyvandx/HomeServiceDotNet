using System.ComponentModel.DataAnnotations;
using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.EndPoints.UI.RazorPages.Areas.Account.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IAccountAppService _accountAppService;

        public RegisterModel(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        [BindProperty]
        public RegisterDto Input { get; set; }


        public class InputModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ProfileImage { get; set; }
            public int Age { get; set; }
            public bool IsCustomer { get; set; }
            public bool IsExpert { get; set; }
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (!ModelState.IsValid) return Page();

            if (Input.IsCustomer && Input.IsExpert)
            {
                ModelState.AddModelError(string.Empty, "همزمان نمیتوانید هم مشتری باشید هم متخصص");
                return Page();
            }

            returnUrl ??= Url.Content("~/");

            var result = await _accountAppService.Register(Input);

            if (result.Count == 0)
            {
                return LocalRedirect(returnUrl);
            }

            foreach (var error in result)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();

        }

    }

}
