﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class SubCategory
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual int CategoryId { get; set; }

        public virtual ICollection<SubCategoryToProduct> SubCategoryToProducts { get; set; }

    }
}
