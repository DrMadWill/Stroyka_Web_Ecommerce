using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class Image
    {
        public virtual int Id { get; set; }

        [MaxLength(300)]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual Detail ProductDetail { get; set; }
        public virtual int ProductDetailId { get; set; }

    }
}
