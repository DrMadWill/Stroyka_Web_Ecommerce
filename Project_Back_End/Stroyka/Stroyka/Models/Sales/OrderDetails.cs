using Stroyka.Models.Products;
using System;

namespace Stroyka.Models.Sales
{
    public class OrderDetails
    {
        public int Id { get; set; }

        // Order Table Connect | One To Many
        public Order Order { get; set; }
        public int OrderId { get; set; }

        // Product Table Connect | One To Many
        public Product Product { get; set; }
        public int ProductId { get; set; }

        // Total Price Sale Price
        public float Total { get; set; }
        public int Quantity { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
