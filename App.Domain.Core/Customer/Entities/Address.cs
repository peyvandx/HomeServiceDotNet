using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int? ExpertId { get; set; }
        public Expert.Entities.Expert? Expert { get; set; }
        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}
