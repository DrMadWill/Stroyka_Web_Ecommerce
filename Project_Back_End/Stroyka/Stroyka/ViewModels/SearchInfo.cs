using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels
{
    public class SearchInfo
    {
        public List<int> ColorIds { get; set; }
        public List<int> BrandIds { get; set; }
        public List<int> MaterialIds { get; set; }

        public float MaxPrice { get; set; }
        public float MinPrice { get; set; }

    }
}
