using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ExpertDto
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileImage { get; set; }
        public string? AboutMe { get; set; }
        public string? FacebookAddress { get; set; }
        public string? TwitterAddress { get; set; }
        public string? InstagramAddress { get; set; }
        public string? LinkedinAddress { get; set; }
        public int? Age { get; set; }
        public int? AverageScores { get; set; }
        public List<int>? ServiceIds { get; set; }
        public Address? Address { get; set; }
        public List<Service>? Services { get; set; }
    }
}
