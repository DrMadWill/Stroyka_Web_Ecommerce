using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Blogs;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Stroyka.Controllers
{
    public class BlogController : Controller
    {

        private readonly StroykaDbContext _dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public BlogController( StroykaDbContext dbContext, UserManager<User> _userManager,RoleManager<IdentityRole> _roleManager)
        {
            _dbContext = dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
        }
        



        public async Task<IActionResult> Index(int? id)
        {

            var blogsQuery = _dbContext.Blogs.AsNoTracking().AsQueryable();
            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, id ?? 1, 10, "/Blog/Index");
            return View(blogs);
        }
    }
}
