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
    public class BlogAsistantController : Controller
    {

        private readonly StroykaDbContext _dbContext;
        public BlogAsistantController(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> BlogListByCategory(int? id,int? page)
        {
            if (id == null) return NotFound();
            var category = await _dbContext.BlogCategories.FirstOrDefaultAsync(b => b.Id == id);
            if (category == null) return NotFound();


            var blogsQuery = _dbContext.Blogs
                .Where(dr=>dr.Category.Id == category.Id)
                .OrderByDescending(x=>x.Date)
                .Include(x=>x.Category)
                .AsNoTracking().AsQueryable();
            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, page ?? 1, 15, "/BlogAsistant/BlogListByCategory/"+id.ToString());
            BlogListByCategoryVM blogListByCategory = new()
            {
                Category = category,
                Blogs = blogs
            };
            return View(blogListByCategory);
        }
    }
}
