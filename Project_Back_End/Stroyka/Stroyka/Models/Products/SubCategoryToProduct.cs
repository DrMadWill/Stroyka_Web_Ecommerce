
namespace Stroyka.Models.Products
{
    public class SubCategoryToProduct
    {
        public virtual int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
