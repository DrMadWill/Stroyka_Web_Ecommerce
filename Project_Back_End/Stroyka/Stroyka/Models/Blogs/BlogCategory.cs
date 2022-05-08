using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.Blogs
{
    public class BlogCategory
    {
        public virtual int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public virtual List<Blog> Blogs { get; set; }

    }
}
