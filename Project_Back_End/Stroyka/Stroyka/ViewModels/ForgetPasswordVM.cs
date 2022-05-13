using System.ComponentModel.DataAnnotations;

namespace Stroyka.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        public string Email { get; set; }
    }
}
