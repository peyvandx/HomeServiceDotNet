using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public int ExpertId { get; set; }
        public string? ExpertFirstName { get; set; }
        public string? ExpertLastName { get; set; }
    }
}
