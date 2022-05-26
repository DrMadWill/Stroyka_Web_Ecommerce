using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using Stroyka.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stroyka.Models.Products;

namespace Stroyka.ViewComponents
{
    public class SearchSideBarViewComponent:ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public SearchSideBarViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var megaCategory = await _dbContext.ProductMegaCategories.FirstOrDefaultAsync(dr=>dr.Id == id);
            var categoies = await _dbContext.ProductCategories
                .Where(x=>x.MegaCategoryId == id).Include(_ => _.SubCategories).ToListAsync();
            megaCategory.Categories = categoies;

            var colors = await _dbContext.ProductColors.ToListAsync();
                
                
                
                

            var date = DateTime.Now.AddMonths(-3);

            ProductListSideBarVM sideBar = new()
            {
                MegaCategory = megaCategory,
                Products = await _dbContext.Products.Where(dr => dr.Date > date).Take(5).ToListAsync(),
                Colors = new(),

            };
            return View(sideBar);
        }
    }
}
