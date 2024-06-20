using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Services;
using App.Domain.Core.Customer.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class BaseAppService : IBaseAppService
    {
        private readonly IBaseService _baseService;
        private readonly ICustomerService _customerService;

        public BaseAppService(IBaseService baseService,
            ICustomerService customerService)
        {
            _baseService = baseService;
            _customerService = customerService;
        }

        //public async Task<int?> GetCustomerUserId(int applicationUserId, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException(); ;
        //}

        //public async Task<int?> GetExpertUserId(int applicationUserId, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<string> UploadImage(IFormFile image)
        {
            return await _baseService.UploadImage(image);
        }
    }
}
