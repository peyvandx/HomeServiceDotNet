using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class AccountAppService : IAccountAppService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
		private readonly ICustomerAppService _customerAppService;
        private readonly IExpertAppService _expertAppService;

        public AccountAppService(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            ICustomerAppService customerAppService,
            IExpertAppService expertAppService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
			_customerAppService = customerAppService;
            _expertAppService = expertAppService;
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

            user.UserName = registerDto.Email;
            user.Email = registerDto.Email;
            //user.SecurityStamp = Guid.NewGuid().ToString();

            if (registerDto.IsCustomer)
            {
                role = "Customer";
                user.Customer = new Core.Customer.Entities.Customer()
                {
                    
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                };
            }

            if (registerDto.IsExpert)
            {
                role = "Expert";
                user.Expert = new Core.Expert.Entities.Expert()
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                };
            }

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (registerDto.IsCustomer)
            {
                var userCustomerId = user.Customer!.Id;
                await _userManager.AddClaimAsync(user, new Claim("userCustomerId", userCustomerId.ToString()));
            }

            if (registerDto.IsExpert)
            {
                var userExpertId = user.Expert!.Id;
                await _userManager.AddClaimAsync(user, new Claim("userExpertId", userExpertId.ToString()));
            }

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, role);

            return (List<IdentityError>)result.Errors;
        }

        public async Task<CustomerProfileDto> GetCustomerProfileDetails(int? userId, int applicationUserId, CancellationToken cancellationToken)
        {
            var customerProfileDto = await _userManager.Users
                .Select(x => new CustomerProfileDto()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                }).FirstOrDefaultAsync(x => x.Id == applicationUserId, cancellationToken);

            var customerResult = await _customerAppService.GetCustomerById(userId, cancellationToken);

            customerProfileDto.ProfileImageUrl = customerResult.ProfileImage;
            customerProfileDto.FirstName = customerResult.FirstName;
            customerProfileDto.LastName = customerResult.LastName;
            customerProfileDto.Address = customerResult.Address;
            customerProfileDto.AboutMe = customerResult.AboutMe;
            customerProfileDto.InstagramAddress = customerResult.InstagramAddress;
            customerProfileDto.FacebookAddress = customerResult.FacebookAddress;
            customerProfileDto.LinkedinAddress = customerResult.LinkedinAddress;
            customerProfileDto.TwitterAddress = customerResult.TwitterAddress;

            return customerProfileDto;

        }

        public async Task<ExpertProfileDto> GetExpertProfileDetails(int? userId, int applicationUserId, CancellationToken cancellationToken)
        {
            var expertProfileDto = await _userManager.Users
                .Select(x => new ExpertProfileDto()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                }).FirstOrDefaultAsync(x => x.Id == applicationUserId, cancellationToken);

            var expertResult = await _expertAppService.GetExpertById(userId, cancellationToken);

            expertProfileDto.ProfileImageUrl = expertResult.ProfileImage;
            expertProfileDto.FirstName = expertResult.FirstName;
            expertProfileDto.LastName = expertResult.LastName;
            expertProfileDto.Address = expertResult.Address;
            expertProfileDto.Age = expertResult.Age;
            expertProfileDto.AboutMe = expertResult.AboutMe;
            expertProfileDto.ServiceIds = expertResult.ServiceIds;
            expertProfileDto.InstagramAddress = expertResult.InstagramAddress;
            expertProfileDto.TwitterAddress = expertResult.TwitterAddress;
            expertProfileDto.FacebookAddress = expertResult.FacebookAddress;
            expertProfileDto.LinkedinAddress = expertResult.LinkedinAddress;

            return expertProfileDto;
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

        public async Task<UserDetailsDto> GetUserDetailsFromUsersTable(int? applicationUserId, CancellationToken cancellationToken)
        {
            var userDetails = await _userManager.Users
                .Select(x => new UserDetailsDto()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                }).FirstOrDefaultAsync(x => x.Id == applicationUserId, cancellationToken);

            return userDetails;
        }
    }
}
