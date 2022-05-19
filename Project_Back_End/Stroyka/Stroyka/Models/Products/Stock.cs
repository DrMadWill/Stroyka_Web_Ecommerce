using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class Stock
    {
        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Material Material { get; set; }
        public virtual int MaterialId { get; set; }
        public virtual Color Color { get; set; }
        public virtual int ColorId { get; set; }
        public int Count { get; set; }

        [NotMapped]
        public bool IsStock { get; set; }

    }
}
