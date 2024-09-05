using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ProfileViewModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
