using Stroyka.Extensions;
using Stroyka.Models.Blogs;

namespace Stroyka.ViewModels
{
    public class BlogListByTagVM
    {
        public PaginationList<Blog> Blogs { get; set; }
        public Tag Tag { get; set; }
    }
}
