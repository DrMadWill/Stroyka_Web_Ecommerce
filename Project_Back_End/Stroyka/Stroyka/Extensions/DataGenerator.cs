


using Stroyka.Models;
using Stroyka.Models.Blogs;
using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.Extensions
{
    public static class DataGenerator
    {
        public static List<List<Product>> GenarateNewArrivals(this List<Product> products)
        {
            List<List<Product>> productListList = new();
            if (products.Count % 2 == 0)
                for (int i = 0; i < products.Count; i += 2)
                    productListList.Add(new List<Product> { products[i], products[i + 1] });
            else
            {
                for (int i = 0; i < products.Count - 1; i += 2)
                    productListList.Add(new List<Product> { products[i], products[i + 1] });

                productListList.Add(new List<Product> { products[^1] });
            }
            return productListList;
        }
    }
}
