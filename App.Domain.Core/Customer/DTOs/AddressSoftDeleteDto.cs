using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class AddressSoftDeleteDto
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
