using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        //public int ProvinceId { get; set; }
        //public Province Province { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
