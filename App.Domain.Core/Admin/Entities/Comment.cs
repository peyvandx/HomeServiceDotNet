using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDeleted { get; set; }
        public int Rate { get; set; }
        public int CustomerSenderId { get; set; }
        public Customer.Entities.Customer CustomerSender { get; set; }
        public int CustomerReceiverId { get; set; }
        public Customer.Entities.Customer CustomerReceiver { get; set; }
        public int ExpertId { get; set; }
        public int ExpertSenderId { get; set; }
        public Expert.Entities.Expert ExpertSender { get; set; }
        public int ExpertReceiverId { get; set; }
        public Expert.Entities.Expert ExpertReceiver { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
