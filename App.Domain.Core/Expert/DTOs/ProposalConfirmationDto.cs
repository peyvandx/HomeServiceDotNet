using App.Domain.Core.Customer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ProposalConfirmationDto
    {
        public int ProposalId { get; set; }
        public int ServiceRequestId { get; set; }
        public ServiceRequestStatus ServiceRequestNewStatus { get; set; }
    }
}
