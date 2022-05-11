using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Products
{
    public class IndexSlider
    {
        [Key]
        public virtual int Id { get; set; }
        public string MiniDescription { get; set; }

        [MaxLength(50)]
        public string BtnName { get; set; }
        
        [MaxLength(500)]
        public string BtnLink { get; set; }
        public string Title { get; set; }
        public string  Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
