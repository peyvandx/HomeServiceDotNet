using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
	[Authorize(Roles = "Customer,Expert")]
	public class ProfileModel : PageModel
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IProvinceAppService _provinceAppService;
        private readonly ICityAppService _cityAppService;
		private readonly IAccountAppService _accountAppService;

		public ProfileModel(ICustomerAppService customerAppService,
            IProvinceAppService provinceAppService,
            ICityAppService cityAppService,
            IAccountAppService accountAppService)
        {
            _customerAppService = customerAppService;
            _provinceAppService = provinceAppService;
            _cityAppService = cityAppService;
			_accountAppService = accountAppService;
		}

        [BindProperty]
        public CustomerProfileDto CustomerProfileDetails { get; set; }
        public List<ProvinceDto> Provinces { get; set; }
        public List<CityDto> Cities { get; set; }


        public async Task OnGet(CancellationToken cancellationToken)
        {
            //Provinces = await _provinceAppService.GetProvinces(cancellationToken);
            Cities = await _cityAppService.GetCities(cancellationToken);
            var applicationUserId = int.Parse(User.Claims.First().Value);
            var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userCustomerId").Value);
            TempData["UserId"] = userId;

			if (User.IsInRole("Customer"))
			{
                CustomerProfileDetails = await _accountAppService.GetCustomerProfileDetails(userId, applicationUserId, cancellationToken);
			}

			if (User.IsInRole("Expert"))
			{
			}
		}

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            await _customerAppService.UpdateCustomer(CustomerProfileDetails, cancellationToken);
            return LocalRedirect("~/Index");
        }
    }
}

//------------------------------------------
//public async Task<string> UploadImage(IFormFile image)
//{
//    string filePath;

//    if (image != null && image.Length > 0)
//    {
//        filePath = @"E:\Project\HomeService\HomeService.Endpoint.RazorPages.UI\wwwroot\uploads\" + image.FileName;
//        using (var stream = new FileStream(filePath, FileMode.Create))
//        {
//            await image.CopyToAsync(stream);
//        }
//        return filePath;
//    }
//    return null;
//}




//اینو توی base service نوشتم

//public async Task<bool> Create(ServiceSubCategoryCreateDto serviceSubCategoryCreateDto, CancellationToken cancellationToken, IFormFile image)
//{
//    var imageAddress = await _baseSevices.UploadImage(image);
//    serviceSubCategoryCreateDto.Image = imageAddress;
//    return await _serviceSubCategoryServices.Create(serviceSubCategoryCreateDto, cancellationToken);
//}

//[BindProperty]
//public IFormFile Image { get; set; }

//public async Task<IActionResult> OnPostAdd(ServiceSubCategoryCreateDto serviceSubCategoryCreate, CancellationToken cancellationToken, IFormFile image)
//{
//    await _servicSubCategoryAppServices.Create(serviceSubCategoryCreate, cancellationToken, image);
//    return RedirectToPage("SubCategory");
//}
//}


//توی کلاس سی شارپی

//enctype="multipart/form-data"
//public async Task<string> UploadImage(IFormFile image)
//{
//    string filePath;

//    if (image != null && image.Length > 0)
//    {
//        filePath = @"E:\Project\HomeService\HomeService.Endpoint.RazorPages.UI\wwwroot\uploads\" + image.FileName;
//        using (var stream = new FileStream(filePath, FileMode.Create))
//        {
//            await image.CopyToAsync(stream);
//        }
//        return filePath;
//    }
//    return null;
//}




//اینو توی base service نوشتم
//public async Task<bool> Create(ServiceSubCategoryCreateDto serviceSubCategoryCreateDto, CancellationToken cancellationToken, IFormFile image)
//{
//    var imageAddress = await _baseSevices.UploadImage(image);
//    serviceSubCategoryCreateDto.Image = imageAddress;
//    return await _serviceSubCategoryServices.Create(serviceSubCategoryCreateDto, cancellationToken);
//}
//[BindProperty]
//public IFormFile Image { get; set; }

//public async Task<IActionResult> OnPostAdd(ServiceSubCategoryCreateDto serviceSubCategoryCreate, CancellationToken cancellationToken, IFormFile image)
//{
//    await _servicSubCategoryAppServices.Create(serviceSubCategoryCreate, cancellationToken, image);
//    return RedirectToPage("SubCategory");
//}
//}


//توی کلاس سی شارپی
//enctype="multipart/form-data"