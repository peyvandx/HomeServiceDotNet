using App.Domain.Core.Customer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class ServiceRequestChangeStatusDto
    {
        public int ServiceRequestId { get; set; }
        public int ExpertId { get; set; }
        public ServiceRequestStatus NewStatus { get; set; }
    }
}
