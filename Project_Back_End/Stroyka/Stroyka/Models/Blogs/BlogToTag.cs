namespace Stroyka.Models.Blogs
{
    public class BlogToTag
    {
        public virtual Blog Blog { get; set; }
        public virtual int BlogId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual int TagId { get; set; }
    }
}
