using Stroyka.Models;
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
                new CategoryType{ Id = "xl" , Name = "Extra Large" },
                new CategoryType{ Id="lg", Name="Large" },
                new CategoryType{ Id="nl", Name="Normal" },
                new CategoryType{ Id="sm",Name="Small" }
            }; ;
        }

    }
}
