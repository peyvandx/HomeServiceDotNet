using App.Domain.Core.Admin.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public Admin? Admin { get; set; }
        //public int? AdminId { get; set; }
        public Customer.Entities.Customer? Customer { get; set; }
        //public int? CustomerId { get; set; }
        public Expert.Entities.Expert? Expert { get; set; }
        //public int? ExpertId { get; set; }
        //public UserRole UserRole { get; set; }
    }
}
