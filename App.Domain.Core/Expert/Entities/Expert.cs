using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Entities;

namespace App.Domain.Core.Expert.Entities
{
    public class Expert
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
        public DateTime SignUpDate { get; set; } = DateTime.Now;
        public int? Age { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        public List<Proposal>? Proposals { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Skill>? Skills { get; set; }
        public List<Service>? Services { get; set; }
        public List<ServiceRequest>? DonedServiceRequests { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
