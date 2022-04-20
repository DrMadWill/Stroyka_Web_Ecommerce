using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class MegaCategory
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

    }
}
