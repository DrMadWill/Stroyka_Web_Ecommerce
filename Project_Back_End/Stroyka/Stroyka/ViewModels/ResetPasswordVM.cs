using System.ComponentModel.DataAnnotations;

namespace Stroyka.ViewModels
{
    public class ResetPasswordVM
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Password Format is Valid")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Required(ErrorMessage = "ConfirmPassword is required.")]
        public string ConfirmPassword { get; set; }
    }
}
