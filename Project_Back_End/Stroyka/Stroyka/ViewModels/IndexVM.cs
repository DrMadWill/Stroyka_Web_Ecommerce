using Stroyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.ViewModels
{
    public class IndexVM
    {
        public List<IndexSlider> IndexSliders { get; set; }
        public List<Category> Categories { get; set; }
    }
}
