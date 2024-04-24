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
        public string Street { get; set; }
        public int PostalCode { get; set; }
    }
}
