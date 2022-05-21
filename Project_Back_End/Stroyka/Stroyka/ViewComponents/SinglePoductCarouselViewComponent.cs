using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Stroyka.Data;
using System.Threading.Tasks;

namespace Stroyka.ViewComponents
{
    public class SinglePoductCarouselViewComponent: ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public SinglePoductCarouselViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
           var data = await _dbContext.SubCategoryToProducts
                .Where(dr=>dr.SubCategory.CategoryId == id)
                .Include(x=>x.Product.Status)
                .Include(x=>x.Product.Reviews)
                .Select(x=>x.Product)
                .ToListAsync();
            return View(data);
        }
    }
}
