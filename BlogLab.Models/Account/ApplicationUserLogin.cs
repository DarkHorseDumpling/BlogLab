using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Username must be at least 5 characters")]
        [MaxLength(20, ErrorMessage = "Username must be less than 20 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Password must be at least 10 characters")]
        [MaxLength(50, ErrorMessage = "Password must be less than 50 characters")]
        public string Password { get; set; }
    }
}
