using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        //public Enum WorkExperience { get; set; } //kamtar az yek sal, beyne yek ta do sal, 2 ta 3 sal, 3 ta 4 sal, 4 ta 5 sal, bishtar az 5 sal.
    }
}
