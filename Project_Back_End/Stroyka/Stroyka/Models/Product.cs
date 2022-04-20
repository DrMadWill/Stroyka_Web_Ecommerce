using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class Product
    {
        public virtual int Id { get; set; }

        [MaxLength(400)]
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Image { get; set; }

        public virtual Status Status { get; set; }
        public virtual int StatusId { get; set; }

        public virtual Material Material { get; set; }
        public virtual int MaterialId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual int BrandId { get; set; }
        
        public virtual ICollection<SubCategoryToProduct> SubCategoryToProducts { get; set; }
    }
}
