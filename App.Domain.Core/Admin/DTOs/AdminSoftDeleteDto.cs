using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.DTOs
{
    public class AdminSoftDeleteDto
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
