using System.Collections.Generic;
using Stroyka.Extensions;
using Stroyka.Models.Products;

namespace Stroyka.ViewModels
{
    public class ProductListVM
    {
        public PaginationList<Product> Products { get; set; }

        public string SearchKey { get; set; }
        public string Action { get; set; }

        public int SearchId { get; set; }

        public int MegaCategoryId { get; set; }

    }
}
