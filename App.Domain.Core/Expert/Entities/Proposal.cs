using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Entities;
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
        public string Description { get; set; }
        public int SuggestedPrice { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsDeleted { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
        public bool IsConfirmedByAdmin { get; set; } //momkene lazem nabashe
        public Admin.Entities.Admin Admin { get; set; } //momkene lazem nabashe
    }
}
