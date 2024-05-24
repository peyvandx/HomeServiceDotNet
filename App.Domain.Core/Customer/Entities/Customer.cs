
using App.Domain.Core.Admin.Entities;

namespace App.Domain.Core.Customer.Entities
{
    public class Customer
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImage { get; set; }
        public string? AboutMe { get; set; }
        public string? FacebookAddress { get; set; }
        public string? TwitterAddress { get; set; }
        public string? InstagramAddress { get; set; }
        public string? LinkedinAddress { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? SignUpDate { get; set; } = DateTime.Now;
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<ServiceRequest>? ServiceRequests { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
