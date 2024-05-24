using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? SignUpDate { get; set; } = DateTime.Now;
        public string? ProfileImage { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        //public List<Comment>? Comments { get; set; }
        //public List<Expert.Entities.Expert>? Experts { get; set; }
        //public List<Customer.Entities.Customer>? Customers { get; set; }
    }
}
