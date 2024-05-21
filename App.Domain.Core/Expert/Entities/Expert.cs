
using App.Domain.Core.Customer.Entities;

namespace App.Domain.Core.Expert.Entities
{
    public class Expert
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime? SignUpDate { get; set; } = DateTime.Now;
        public int? Age { get; set; }
        public bool IsDeleted { get; set; } = false;
        //public bool IsConfirmed { get; set; } = true;
        //public int? AdminId { get; set; }
        //public Admin.Entities.Admin? Admin { get; set; }
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        public List<Proposal>? Proposals { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Skill>? Skills { get; set; }
        public List<Service>? Services { get; set; }
        public List<ServiceRequest>? DonedServiceRequests { get; set; }
    }
}
