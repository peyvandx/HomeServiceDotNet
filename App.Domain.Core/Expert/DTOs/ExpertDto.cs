using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ExpertDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImage { get; set; }
        public DateTime SignUpDate { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsConfirmed { get; set; } = false;
    }
}
