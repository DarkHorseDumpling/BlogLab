using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Full name must be at least 10 characters")]
        [MaxLength(30, ErrorMessage = "Full name must be less than 30 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email must have less than 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
