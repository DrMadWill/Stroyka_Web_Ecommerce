using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.Commoun
{
    public class EmailForSubscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(320)]
        [MinLength(3)]
        [Required]
        public string Email { get; set; }

        public bool IsBlog { get; set; }
        public bool IsProduct { get; set; }

    }
}
