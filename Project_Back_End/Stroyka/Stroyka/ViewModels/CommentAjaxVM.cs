using System;

namespace Stroyka.ViewModels
{
    public class CommentAjaxVM
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public int BlogId { get; set; }
        public DateTime Date { get; set; } 
        public bool IsChild { get; set; }
        public int? ParentId { get; set; }
        public string HtmlId { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string ParentUserName { get; set; }

    }
}
