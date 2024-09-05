using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
