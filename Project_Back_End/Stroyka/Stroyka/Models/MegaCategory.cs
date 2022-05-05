using Stroyka.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(4)]
        public string CategoryTypeClass { get; set; }

        [NotMapped]
        public string ClassCol
        {
            get
            {
                CategoryTypeData categoryType = new();
                string id = CategoryTypeClass ?? string.Empty;
                return categoryType.GetColById(id) ?? string.Empty;
            }
        }

    }
}
