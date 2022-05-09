using Stroyka.Extensions;
using Stroyka.Models.Blogs;

namespace Stroyka.ViewModels
{
    public class BlogListByCategoryVM
    {
        public PaginationList<Blog> Blogs { get; set; }
        public Category Category { get; set; }
    }
}
