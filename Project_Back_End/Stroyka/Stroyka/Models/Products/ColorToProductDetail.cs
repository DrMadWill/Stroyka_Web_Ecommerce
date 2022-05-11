

namespace Stroyka.Models.Products
{
    public class ColorToProductDetail
    {
        public virtual ProductDetail ProductDetail { get; set; }
        public virtual int ProductDetailId { get; set; }

        public virtual Color Color { get; set; }
        public virtual int ColorId { get; set; }
    }
}
