using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class RequestProposalIdsDto
    {
        public int ProposalId { get; set; }
        public int ServiceRequestId { get; set; }
        public int ProposalExpertId { get; set; }
    }
}
