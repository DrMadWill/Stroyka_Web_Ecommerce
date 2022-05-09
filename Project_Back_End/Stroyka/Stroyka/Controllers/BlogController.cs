using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Blogs;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using System.Linq;
using System.Threading.Tasks;


namespace Stroyka.Controllers
{
    public class BlogController : Controller
    {

        private readonly StroykaDbContext _dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public BlogController(StroykaDbContext dbContext, UserManager<User> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            _dbContext = dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var blogsQuery = _dbContext.Blogs.
                OrderByDescending(x => x.Date)
                .Include(x => x.Category)
                .AsNoTracking().AsQueryable();
            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, id ?? 1, 10, "/Blog/Index");
            return View(blogs);
        }


        public async Task<IActionResult> Single(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _dbContext.Blogs
                .Include(x => x.Category)
                .Include(x=>x.SubCategory)
                .Include(x=>x.User)
                .Include(x=>x.Detail)
                .FirstOrDefaultAsync(dr => dr.Id == id);
            if (blog == null) return NotFound();

            BlogVM blogVM = new()
            {
                Blog = blog,
                Tags = await _dbContext.BlogToTags
                .Where(dr => dr.BlogId == blog.Id).Select(x => x.Tag).ToListAsync(),
                Comments = await _dbContext.Comments
                .Where(dr=>dr.BlogId == blog.Id && dr.ParentId == null)
                .Include(x=>x.User)
                .OrderBy(x=>x.Date)
                .Take(5)
                .ToListAsync(),
                CommentCount = await _dbContext.Comments.Where(dr => dr.BlogId == blog.Id).CountAsync()
            };

            return View(blogVM);
        }
    }
}
