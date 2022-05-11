using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stroyka.Data;

namespace Stroyka.ViewComponents
{
    public class RelatedBlogViewComponent: ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public RelatedBlogViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var category = await _dbContext.BlogCategories.FindAsync(id);
            var blogs = await _dbContext.Blogs
                .Where(dr => dr.CategoryId == category.Id)
                .OrderByDescending(x => x.Date)
                .Take(2)
                .ToListAsync();
            return View(blogs);
        }

    }
}
