using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Services
{
    public interface IAccountService
    {
        public Task<int> GetCustomerIdFromUserId(int userId, CancellationToken cancellationToken);
    }
}
