using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public string ExpertDescription { get; set; }
        public double? SuggestedPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsAccepted { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsRejected { get; set; } = false;
        public ProposalStatus Status { get; set; }
        public int? ExpertId { get; set; }
        public Expert Expert { get; set; }
        public int? ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
    }
}
