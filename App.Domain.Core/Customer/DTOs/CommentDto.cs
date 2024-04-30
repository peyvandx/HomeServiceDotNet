using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        //public DateTime CreateDate { get; set; }
        //public bool IsConfirmed { get; set; } = false;
        //public bool IsDeleted { get; set; } = false;
        public int Rate { get; set; }
        public int CustomerId { get; set; }
        public int ExpertId { get; set; }
        public int AdminId { get; set; }
    }
}
