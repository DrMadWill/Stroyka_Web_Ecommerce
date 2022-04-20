using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class CategoryType
    {
        [Key]
        [MaxLength(4)]
        public virtual string Id { get; set; }
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }

    }
}
