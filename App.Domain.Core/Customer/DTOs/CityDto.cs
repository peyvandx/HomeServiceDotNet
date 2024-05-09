using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public bool IsDeleted { get; set; } = false;
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
    }
}
