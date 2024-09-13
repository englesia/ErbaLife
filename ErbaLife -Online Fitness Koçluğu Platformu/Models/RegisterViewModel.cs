using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http; // IFormFile için gerekli

namespace WebApplication2.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        // Fotoğraf URL'si veritabanında saklanacak
        public string ? ProfilePictureUrl { get; set; }

        // Fotoğraf dosyası yükleme için
        public IFormFile ? ProfilePicture { get; set; }
    }
}
