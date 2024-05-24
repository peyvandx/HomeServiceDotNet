using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class CustomerDto
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileImage { get; set; }
        public string? AboutMe { get; set; }
        public string? FacebookAddress { get; set; }
        public string? TwitterAddress { get; set; }
        public string? InstagramAddress { get; set; }
        public string? LinkedinAddress { get; set; }
        public Address Address { get; set; }
    }
}
