using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using Stroyka.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Stroyka.ViewComponents
{
    public class SearchSideBarViewComponent:ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public SearchSideBarViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var date = DateTime.Now.AddMonths(-3);
            ProductListSideBarVM sideBar = new()
            {
                Products = await _dbContext.Products.Where(dr => dr.Date > date).Take(5).ToListAsync(),
                Colors = new()

            };
            return View(sideBar);
        }
    }
}
