using Stroyka.Extensions;
using Stroyka.Models.Blogs;

namespace Stroyka.ViewModels
{
    public class BlogListBySubCategoryVM
    {
        public PaginationList<Blog> Blogs { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
