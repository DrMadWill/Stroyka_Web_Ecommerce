using Stroyka.Extensions;
using Stroyka.Models.Products;
using System;

namespace Stroyka.ViewModels.AjaxModels
{
    public class ProductAM:BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public float CurrentPrice { get; set; }
        public float? OldPrice { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public byte Stars { get; set; }
        public int StockCount { get; set; }
        public bool IsInStock { get; set; }
        public virtual Status Status { get; set; }
        public virtual int StatusId { get; set; }
        public virtual Detail ProductDetail { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual int BrandId { get; set; }
        public int ReviewsCount { get; set; }
    }
}
