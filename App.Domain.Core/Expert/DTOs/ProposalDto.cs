using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ProposalDto
    {
        public int Id { get; set; }
        public string ExpertDescription { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ExpertEmail { get; set; }
        public string ExpertPhoneNumber { get; set; }
        public int ExpertId { get; set; }
        //public Expert.Entities.Expert Expert { get; set; }
        public string? ExpertFirstName { get; set; }
        public string? ExpertLastName { get; set; }
        public string? ExpertProfileImage { get; set; }
        public DateTime ExpertSignUpDate { get; set; }
        public int ServiceRequestId { get; set; }
        public bool? IsAccepted { get; set; }
    }
}
