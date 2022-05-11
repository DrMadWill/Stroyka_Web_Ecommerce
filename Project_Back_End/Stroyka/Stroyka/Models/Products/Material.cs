using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Stroyka.Models.Products
{
    public class Material
    {

        public virtual int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
