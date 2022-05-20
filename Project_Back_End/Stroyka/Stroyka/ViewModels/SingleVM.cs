using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels
{
    public class SingleVM
    {
        public Product Product { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Category> Categories { get; set; }

    }
}
