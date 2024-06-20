using App.Domain.AppServices.Admin;
using App.Domain.AppServices.Customer;
using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    [Authorize(Roles = "Customer,Expert")]
    public class ProfileModel : PageModel
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IExpertAppService _expertAppService;
        private readonly IProvinceAppService _provinceAppService;
        private readonly ICityAppService _cityAppService;
        private readonly IAccountAppService _accountAppService;
        private readonly IServiceAppService _serviceAppService;
        private readonly IBaseAppService _baseAppService;

        public ProfileModel(ICustomerAppService customerAppService,
            IExpertAppService expertAppService,
            IProvinceAppService provinceAppService,
            ICityAppService cityAppService,
            IAccountAppService accountAppService,
            IServiceAppService serviceAppService,
            IBaseAppService baseAppService)
        {
            _customerAppService = customerAppService;
            _expertAppService = expertAppService;
            _provinceAppService = provinceAppService;
            _cityAppService = cityAppService;
            _accountAppService = accountAppService;
            _serviceAppService = serviceAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public CustomerProfileDto CustomerProfileDetails { get; set; }
        [BindProperty]
        public ExpertProfileDto ExpertProfileDetails { get; set; }
        [BindProperty]
        public IFormFile ProfileImage { get; set; }
        public List<ProvinceDto> Provinces { get; set; }
        public List<CityDto> Cities { get; set; }
        public List<ServiceDto> Services { get; set; }


        public async Task OnGet(CancellationToken cancellationToken)
        {
            Cities = await _cityAppService.GetCities(cancellationToken);
            Services = await _serviceAppService.GetServices(cancellationToken);

            var applicationUserId = int.Parse(User.Claims.First().Value);

            if (User.IsInRole("Customer"))
            {
                int? userId;

                var user = User.Claims.FirstOrDefault(c => c.Type == "userCustomerId");
                if (user is not null)
                {
                    userId = int.Parse(user.Value);
                }
                else
                {
                    userId = await _customerAppService.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);
                }
                TempData["UserId"] = userId;
                CustomerProfileDetails = await _accountAppService.GetCustomerProfileDetails(userId, applicationUserId, cancellationToken);
            }

            if (User.IsInRole("Expert"))
            {
                int? userId;
				var user = User.Claims.FirstOrDefault(c => c.Type == "userExpertId");
				if (user is not null)
				{
					userId = int.Parse(user.Value);
				}
				else
				{
					userId = await _expertAppService.GetExpertIdByApplicationUserId(applicationUserId, cancellationToken);
				}
				TempData["UserId"] = userId;
                ExpertProfileDetails = await _accountAppService.GetExpertProfileDetails(userId, applicationUserId, cancellationToken);
            }
        }

        public async Task<IActionResult> OnPostAsync(IFormFile profileImage, CancellationToken cancellationToken)
        {
            if (User.IsInRole("Customer"))
            {
                if (profileImage is not null)
                {
                    var imageUrl = await _baseAppService.UploadImage(profileImage);
                    CustomerProfileDetails.ProfileImageUrl = imageUrl;
                }

                await _customerAppService.UpdateCustomer(CustomerProfileDetails, cancellationToken);
                return LocalRedirect("~/Profile");
            }
            else
            {
                if (profileImage is not null)
                {
                    var imageUrl = await _baseAppService.UploadImage(profileImage);
                    ExpertProfileDetails.ProfileImageUrl = imageUrl;
                }
                
                await _expertAppService.UpdateExpert(ExpertProfileDetails, cancellationToken);
                return LocalRedirect("~/Profile");
            }
        }
    }
}
