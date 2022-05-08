using Stroyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.ViewModels
{
    public class IndexVM
    {
        public List<IndexSlider> IndexSliders { get; set; }
        public List<Category> PopularCategories { get; set; }
        public List<Product> RatedProducts { get; set; }
        public List<MegaCategory> MegaCategories { get; set; }

        public List<List<Product>> NewArrivals { get; set; }

       
    }
}
