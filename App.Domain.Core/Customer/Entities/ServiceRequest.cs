using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Entities
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string CustomerDescription { get; set; }
        public ServiceRequestStatus Status { get; set; }
        public double? CustomerSuggestedPrice { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? ExpertId { get; set; }
        public Expert.Entities.Expert? Expert { get; set; } // oon experti ke customer ghaboolesh karde ke in service request ro anjam bede
        public int? CommentId { get; set; }
        public Comment? Comment { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public List<Proposal> Proposals { get; set; }
    }
}
