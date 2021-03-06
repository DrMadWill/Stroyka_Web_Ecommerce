using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Stroyka.Models.Sales;

namespace Stroyka.Models.Products
{
    public class Product
    {
        public virtual int Id { get; set; }
        [MaxLength(400)]
        [Required]
        public string Name { get; set; }
        [Required]
        public float CurrentPrice { get; set; }
        public float? OldPrice { get; set; }
        [MaxLength(300)]
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public byte Stars { get; set; }
        public string MiniDecription { get; set; }
        public int StockCount { get; set; }

        [NotMapped]
        public bool IsInStock
        {
            get { return StockCount > 0; }
            set => IsInStock = value; 
        }

        public int ReviewCount { get; set; }



        public virtual Status Status { get; set; }
        public virtual int StatusId { get; set; }
        // Product Detail 
        public virtual Detail ProductDetail { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual int BrandId { get; set; }


        public virtual ICollection<SubCategoryToProduct> SubCategoryToProducts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public IList<OrderDetails> OrderDetails { get; set; }
    }
}
