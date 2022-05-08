

using Stroyka.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Blogs
{
    public class Blog
    {
        [Key]
        public virtual int Id { get; set; }
        [MaxLength(200, ErrorMessage = "Maxum Limit 200")]
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(350)]
        [Required(ErrorMessage = "Preview Description is Required")]
        public string PreviewDescription { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;


        public virtual BlogCategory BlogCategory { get; set; }
        public virtual int BlogCategoryId { get; set; }
        public virtual List<BlogToTag> BlogToTags { get; set; }
        public virtual IList<Comment> Comments { get; set; }

        public virtual User User { get; set; }
        [Required]
        public virtual string UserId { get; set; }

        public virtual BlogDetail BlogDetail { get; set; }

        [NotMapped]
        public TimeSpan Time { get { return (DateTime.Now.Subtract(Date)); } }

    }
}
