using Stroyka.Extensions;
using System.Collections.Generic;

namespace Stroyka.ViewModels.AjaxM
{
    public class MaterialAM: BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public List<ColorAM> ColorAMs { get; set; }
    }
}
