using Microsoft.AspNetCore.Identity;
using Stroyka.Models.Blogs;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.Users
{
    public class User:IdentityUser
    {
        [MaxLength(75)]
        [Required]
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string Location { get; set; }
        public bool Gender { get; set; }

        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<Comment> Comments { get; set; }
        public virtual IList<Review> Reviews { get; set; }
    }
}
