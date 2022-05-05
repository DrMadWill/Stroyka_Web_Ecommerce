﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class Category
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        public virtual MegaCategory MegaCategory { get; set; }
        public virtual int MegaCategoryId { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
