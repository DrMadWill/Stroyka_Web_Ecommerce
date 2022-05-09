using Stroyka.Models.Blogs;
using System.Collections.Generic;

namespace Stroyka.ViewModels
{
    public class BlogVM
    {
        public List<Tag> Tags { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
        public int CommentCount { get; set; }
    }
}
