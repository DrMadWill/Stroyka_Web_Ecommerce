using Stroyka.Models;
using Stroyka.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Data
{
    public class CategoryTypeData
    {
        public List<CategoryType> CategoryTypes { get; set; }
        public CategoryTypeData()
        {
            CategoryTypes = new List<CategoryType>
            {
                new CategoryType{ Id = "xl" , Name = "Extra Large",ClassCol= "col-3" },
                new CategoryType{ Id="lg", Name="Large",ClassCol= "col-4" },
                new CategoryType{ Id="nl", Name="Normal",ClassCol= "col-6" },
                new CategoryType{ Id="sm",Name="Small",ClassCol= "col-12" }
            }; ;
        }

        public string GetColById(string id)
        {
            id = id.ToLower();
            return CategoryTypes.Find(x => x.Id == id).ClassCol;
        }

    }
}
