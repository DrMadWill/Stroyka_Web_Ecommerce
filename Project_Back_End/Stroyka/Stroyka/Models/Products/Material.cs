using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class Material
    {

        public virtual int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        [NotMapped]
        public bool IsStock { get; set; }


    }
}
