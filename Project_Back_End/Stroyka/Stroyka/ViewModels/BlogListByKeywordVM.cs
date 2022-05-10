using Stroyka.Extensions;
using Stroyka.Models.Blogs;

namespace Stroyka.ViewModels
{
    public class BlogListByKeywordVM
    {
        public PaginationList<Blog> Blogs { get; set; }
        public string Keyword { get; set; }
    }
}
