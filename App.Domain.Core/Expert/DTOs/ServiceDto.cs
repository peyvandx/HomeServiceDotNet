using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public WorkExperience WorkExperience { get; set; }
        //public bool IsDeleted { get; set; } = false;
        public int CategoryId { get; set; }
    }
}
