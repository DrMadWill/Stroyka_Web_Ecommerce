using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Blogs
{
    public class BlogDetail
    {
        [Key, ForeignKey("Blog")]
        public virtual int Id { get; set; }
        public virtual Blog Blog { get; set; }

        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        

    }
}
