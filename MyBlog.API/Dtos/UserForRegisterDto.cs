using System;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "You must specify password between 6 and 12 characters.")]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }
        
        [Required]
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            RegisterDate = DateTime.Now;
            LastActive = DateTime.Now;
        }


    }
}