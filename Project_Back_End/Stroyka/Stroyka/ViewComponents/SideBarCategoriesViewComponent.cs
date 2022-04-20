using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var megaCategory = await _dbContext.MegaCategories
                .ToListAsync();

            var category = await _dbContext.Categories
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
