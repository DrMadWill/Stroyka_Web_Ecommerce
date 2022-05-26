using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels.ViewComponentModels
{
    public class ProductListSideBarVM
    {
        public List<Brand> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<Material> Materials { get; set; }
        public List<Product> Products { get; set; }

    }
}
