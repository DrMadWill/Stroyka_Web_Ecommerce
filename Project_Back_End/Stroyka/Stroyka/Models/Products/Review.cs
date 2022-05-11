using Stroyka.Models.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stroyka.Models.Products
{
    public class Review
    {
        [Key]
        public virtual int Id { get; set; }
        
        [Required]
        [MaxLength(700)]
        public byte Stars { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Review Parent { get; set; }
        public virtual int? ParentId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public virtual string UserId { get; set; }
    }
}
