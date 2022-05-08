using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class SubCategoryToProduct
    {
        public virtual int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
