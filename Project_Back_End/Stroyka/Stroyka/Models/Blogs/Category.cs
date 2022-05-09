using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.Blogs
{
    public class Category
    {
        public virtual int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<SubCategory> SubCategories { get; set; }

    }
}
