using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SuggestedPrice { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
