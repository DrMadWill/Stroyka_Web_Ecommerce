using System.ComponentModel.DataAnnotations;


namespace Stroyka.Models.Products
{
    public class CategoryType
    {
        [Key]
        [MaxLength(4)]
        public virtual string Id { get; set; }
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        public string ClassCol { get; set; }
    }
}
