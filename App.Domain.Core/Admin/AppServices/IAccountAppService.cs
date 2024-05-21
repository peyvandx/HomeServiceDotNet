using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.AppServices
{
    public interface IAccountAppService
    {
        public Task<List<IdentityError>> Register(RegisterDto registerDto);
        public Task<bool> Login(LoginDto loginDto);
    }
}
