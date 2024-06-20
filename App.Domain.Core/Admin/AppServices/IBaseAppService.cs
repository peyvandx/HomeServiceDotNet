using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.AppServices
{
    public interface IBaseAppService
    {
        public Task<string> UploadImage(IFormFile image);
        //public Task<int?> GetCustomerUserId(int applicationUserId, CancellationToken cancellationToken);
        //public Task<int?> GetExpertUserId(int applicationUserId, CancellationToken cancellationToken);
    }
}
