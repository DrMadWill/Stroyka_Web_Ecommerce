using Stroyka.Models.Products;
using System.Collections.Generic;

namespace Stroyka.ViewModels
{
    public class CompareVM
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public int  Quantity { get; set; }
        public Product Product { get; set; }
    }
}
