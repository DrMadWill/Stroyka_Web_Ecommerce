using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.Blogs
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual Category BlogCategory { get; set; }
        public virtual int BlogCategoryId { get; set; }
    }
}
