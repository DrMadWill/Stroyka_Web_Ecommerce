using Stroyka.Extensions;
using Stroyka.Models.Products;

namespace Stroyka.ViewModels
{
    public class ProductListByKeyVM
    {
        public PaginationList<Product> Products { get; set; }
        public string SearchKey { get; set; }
        public string SearchInfo { get; set; }
        public string SortedKey { get; set; }
        public int MegaCategoryId { get; set; }
    }
}
