using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class ProductDetail
    {
        [ForeignKey("Product"),Key]
        public virtual int Id { get; set; }
        public Product Product { get; set; }
        
        public string MiniDecription { get; set; }
        public bool IsStock { get; set; }
        public string SKU { get; set; }
        [Column(TypeName = "ntext")]
        public string DescriptionFull { get; set; }
        [Column(TypeName = "ntext")]
        public string Specification { get; set; }
       
        public virtual ICollection<ColorToProductDetail> ColorToProductDetails { get; set; }

    }
}
