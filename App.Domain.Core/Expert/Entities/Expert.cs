
namespace App.Domain.Core.Expert.Entities
{
    public class Expert
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImage { get; set; }
        public int Age { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
