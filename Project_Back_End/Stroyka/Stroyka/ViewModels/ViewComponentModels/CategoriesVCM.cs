using Stroyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.ViewModels.ViewComponentModels
{
    public class CategoriesVCM
    {
        public List<MegaCategory> MegaCategories { get; set; }
        public List<Category> Categories { get; set; }
        public bool IsIndex { get; set; }

    }
}
