using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Services;
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

        public BaseAppService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<string> UploadImage(IFormFile image)
        {
            return await _baseService.UploadImage(image);
        }
    }
}
