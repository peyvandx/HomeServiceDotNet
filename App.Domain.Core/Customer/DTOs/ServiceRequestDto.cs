using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class ServiceRequestDto
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceImageUrl { get; set; }
        public string CustomerDescription { get; set; }
        public Status Status { get; set; }
        public double Price { get; set; } //ghimate pardakht shode
        public bool IsDone { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
    }
}
