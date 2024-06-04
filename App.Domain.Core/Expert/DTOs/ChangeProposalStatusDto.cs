using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ChangeProposalStatusDto
    {
        public int ProposalId { get; set; }
        public ProposalStatus NewStatus { get; set; }
    }
}
