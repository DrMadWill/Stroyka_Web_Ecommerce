﻿using System.ComponentModel.DataAnnotations;

namespace Stroyka.ViewModels
{
    public class SignInVM
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
