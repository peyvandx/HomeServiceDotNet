using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Services
{
    public interface IBaseService
    {
        public Task<string> UploadImage(IFormFile image);
    }
}
