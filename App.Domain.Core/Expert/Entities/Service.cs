using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public bool IsDeleted { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public int DonedServiceRequests { get; set; }
        public List<ServiceRequest> DonedServiceRequests { get; set; }
    }
}
