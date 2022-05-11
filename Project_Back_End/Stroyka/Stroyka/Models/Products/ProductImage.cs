using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class ProductImage
    {
        public virtual int Id { get; set; }

        [MaxLength(300)]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
        public virtual int ProductDetailId { get; set; }

    }
}
