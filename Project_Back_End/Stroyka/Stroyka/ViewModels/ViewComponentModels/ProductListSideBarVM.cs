using Stroyka.Models.Products;
using Stroyka.Models.ViewModels.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels.ViewComponentModels
{
    public class ProductListSideBarVM
    {
        public MegaCategory MegaCategory { get; set; }
        public List<BrandStock> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<Material> Materials { get; set; }
        public List<Product> Products { get; set; }
        public float MaxPrice { get; set; }
        public float MinPrice { get; set; }

    }
}
