using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Enums
{
    public enum Status
    {
        WaitingForExpertsProposals = 0,
        WaitingForAcceptAProposal = 1,
        WaitingForExpert = 2,
        Success = 3,
        Failed = 4,
        Canceled = 5,
    }
}
