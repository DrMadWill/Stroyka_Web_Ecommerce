using System.ComponentModel.DataAnnotations;

namespace Stroyka.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email not valid")]
        public string Email { get; set; }
    }
}
