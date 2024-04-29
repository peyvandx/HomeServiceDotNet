﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ProposalDto
    {
        public int Id { get; set; }
        public string ExpertDescription { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}