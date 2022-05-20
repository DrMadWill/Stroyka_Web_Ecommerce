using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stroyka.Data;

namespace Stroyka.ViewComponents
{
    public class SideBarCategoriesViewComponent:ViewComponent
    {

        private readonly StroykaDbContext _dbContext;

        public SideBarCategoriesViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var megaCategory = await _dbContext.ProductMegaCategories
                .ToListAsync();

            var category = await _dbContext.ProductCategories
               .Include(c => c.SubCategories)
               .ToListAsync();

            // Meny Section Include
            foreach (var item in megaCategory)
                item.Categories = category.FindAll(x => x.MegaCategoryId == item.Id);
               

            string name = RouteData.Values["controller"].ToString() + "/" + RouteData.Values["action"];
            ViewBag.IsIndex = name == "Home/Index";

            return View(megaCategory);
        }


    }
}
