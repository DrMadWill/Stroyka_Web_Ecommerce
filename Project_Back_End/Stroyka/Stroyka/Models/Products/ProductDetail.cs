using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stroyka.Models.Products
{
    public class ProductDetail
    {
        [ForeignKey("Product"),Key]
        public virtual int Id { get; set; }
        public Product Product { get; set; }
        
        public string MiniDecription { get; set; }
        public string SKU { get; set; }
        [Column(TypeName = "ntext")]
        public string DescriptionFull { get; set; }
        [Column(TypeName = "ntext")]
        public string Specification { get; set; }
        public virtual IList<ProductImage> ProductImages { get; set; }

    }
}
