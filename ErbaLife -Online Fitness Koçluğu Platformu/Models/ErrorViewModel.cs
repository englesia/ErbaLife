using System.ComponentModel.DataAnnotations;

namespace ErbaLife__Online_Fitness_Koçluğu_Platformu.Models
{
    public class ErrorViewModel
    {
        [Required]
        public string? RequestId { get; set; }
        [Required]
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
