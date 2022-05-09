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
    public class BlogRightSideBarViewComponent : ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public BlogRightSideBarViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            BlogSidebarVCM blogSidebar = new()
            {
                BlogCategories = await _dbContext.BlogCategories.Include(x=>x.SubCategories).ToListAsync(),
                LastestBlogs = await _dbContext.Blogs.OrderByDescending(dr => dr.Date).Take(3).ToListAsync(),
                LastestComments = await _dbContext.Comments.OrderByDescending(dr => dr.Date).Take(3).ToListAsync()
            };
            return View(blogSidebar);
        }


    }
}
