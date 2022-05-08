using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
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
