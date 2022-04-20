using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class Review
    {
        [Key]
        public virtual int Id { get; set; }
        
        [Required]
        [MaxLength(700)]
        public string Email { get; set; }
        public byte Stars { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
        public virtual int ProductDetailId { get; set; }
        public virtual Review Parent { get; set; }
        public virtual int? ParentId { get; set; }
    }
}
