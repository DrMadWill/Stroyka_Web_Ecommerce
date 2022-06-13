using System.ComponentModel.DataAnnotations;

namespace Stroyka.ViewModels
{
    public class SignUpVM
    {
   
        public string UserName { get; set; }

        [MaxLength(100, ErrorMessage = "So Large Full Name")]
        [MinLength(7, ErrorMessage = "So Small Full Name")]
        [Required(ErrorMessage = "Full Name Required")]
        public string FullName { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Select Gender.")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="Email not valid")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Password Format is Valid")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Required(ErrorMessage = "ConfirmPassword is required.")]
        public string ConfirmPassword { get; set; }

        // Location
        public string Location { get; set; }

        [RegularExpression(@"\d{10}|\d{9}", ErrorMessage ="Phone Number Not Valid")]
        public string PhoneNumber { get; set; }

    }
}
