using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class SkillDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SelfRate { get; set; }
        public DateTime CreatedAt { get; set; }
        //public bool IsDeleted { get; set; } = false;
        public int ExpertId { get; set; }
    }
}
