


using Stroyka.Models.Blogs;
using System.Collections.Generic;

namespace Stroyka.ViewModels.ViewComponentModels
{
    public class BlogSidebarVCM
    {
        public List<Category> BlogCategories  { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Blog> LastestBlogs { get; set; }

        public List<Comment> LastestComments { get; set; }


    }
}
