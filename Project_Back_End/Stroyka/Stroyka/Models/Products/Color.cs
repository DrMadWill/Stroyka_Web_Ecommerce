using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class Color
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(7)]
        public string Code { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
