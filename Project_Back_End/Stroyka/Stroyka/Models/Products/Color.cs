using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class Color
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(7)]
        public string Name { get; set; }
        public virtual ICollection<ColorToProductDetail> ColorToProductDetails { get; set; }

    }
}
