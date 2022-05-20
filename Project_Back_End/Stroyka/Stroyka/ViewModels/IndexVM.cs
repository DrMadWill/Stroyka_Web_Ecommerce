using Stroyka.Models.Commoun;
using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels
{
    public class IndexVM
    {
        public List<IndexSlider> IndexSliders { get; set; }
        public List<Category> PopularCategories { get; set; }
        public List<Product> RatedProducts { get; set; }
        public List<MegaCategory> MegaCategories { get; set; }
        public List<List<Product>> NewArrivals { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Product> SpecialOffers { get; set; }


    }
}
