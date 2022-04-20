﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class Brand
    {
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}