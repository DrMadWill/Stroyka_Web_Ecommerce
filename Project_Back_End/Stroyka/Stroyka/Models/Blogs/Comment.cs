using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Stroyka.Models.Users;

namespace Stroyka.Models.Blogs
{
    public class Comment
    {
        [Key]
        public virtual int Id { get; set; }
        [Column(TypeName = "ntext")]
        [Required]
        [MinLength(2)]
        public string Description { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual int BlogId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsBlocked { get; set; } = false;
        public bool IsChild { get; set; }
        public Comment Parent { get; set; }
        public int? ParentId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public virtual string UserId { get; set; }
        // Html Loaction 
        [NotMapped]
        public string HtmlId { get { return "comment" + Id; } }
    }
}
