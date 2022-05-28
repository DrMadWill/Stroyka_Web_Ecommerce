using System.ComponentModel.DataAnnotations;

namespace Stroyka.Models.SqlViews.Products
{
    public class BrandStock
    {
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Image { get; set; }
        public int StockCount { get; set; }
    }
}
