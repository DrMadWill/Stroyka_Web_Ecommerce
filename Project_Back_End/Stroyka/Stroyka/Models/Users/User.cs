using Microsoft.AspNetCore.Identity;
using Stroyka.Models.Blogs;
using Stroyka.Models.Products;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Users
{
    public class User:IdentityUser
    {
        [MaxLength(75)]
        [Required]
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string Location { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        public bool Gender { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<Comment> Comments { get; set; }
        public virtual IList<Review> Reviews { get; set; }
    }
}
