
namespace App.Domain.Core.Customer.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImage { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? SignUpDate { get; set; } = DateTime.Now;
        //public bool IsConfirmed { get; set; } = true;
        //public int AdminId { get; set; }
        //public Admin.Entities.Admin Admin { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<ServiceRequest>? ServiceRequests { get; set; }
    }
}
