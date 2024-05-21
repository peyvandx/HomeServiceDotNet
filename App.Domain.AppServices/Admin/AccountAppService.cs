using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class AccountAppService : IAccountAppService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AccountAppService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }


        public async Task<bool> Login(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, true, lockoutOnFailure: false);

            return result.Succeeded;
        }

        public async Task<List<IdentityError>> Register(RegisterDto registerDto)
        {
            var role = string.Empty;

            var user = CreateUser();

            user.UserName = registerDto.UserName;
            user.Email = registerDto.Email;

            if (registerDto.IsCustomer)
            {
                role = "Customer";
                user.Customer = new Core.Customer.Entities.Customer()
                {

                };
            }

            if (registerDto.IsExpert)
            {
                role = "Expert";
                user.Expert = new Core.Expert.Entities.Expert()
                {

                };
            }

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, role);

            return (List<IdentityError>)result.Errors;
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                                                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}
