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

        // Shearch Blog By Category GET
        [HttpGet]
        public async Task<IActionResult> BlogListByCategory(int? id,int? page)
        {
            if (id == null) return NotFound();
            var category = await _dbContext.BlogCategories.FirstOrDefaultAsync(b => b.Id == id);
            if (category == null) return NotFound();

            // DataBase Select
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

        // Shearch Blog By SubCategory GET
        [HttpGet]
        public async Task<IActionResult> BlogListBySubCategory(int? id, int? page)
        {
            if (id == null) return NotFound();
            var subCategory = await _dbContext.BlogSubCategories
                .Include(x=>x.BlogCategory)
                .FirstOrDefaultAsync(b => b.Id == id);
            if (subCategory == null) return NotFound();
            // DataBase Select
            var blogsQuery = _dbContext.Blogs
                .Where(dr => dr.SubCategoryId == subCategory.Id)
                .OrderByDescending(x => x.Date)
                .Include(x => x.Category)
                .AsNoTracking().AsQueryable();
            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, page ?? 1, 15, "/BlogAsistant/BlogListBySubCategory/" + id.ToString());
            BlogListBySubCategoryVM blogListBySubCategory = new()
            {
                SubCategory = subCategory,
                Blogs = blogs
            };
            return View(blogListBySubCategory);
        }

        // Shearch Blog By Tag GET
        [HttpGet]
        public async Task<IActionResult> BlogListByTag(int? id, int? page)
        {
            if (id == null) return NotFound();
            var tag = await _dbContext.BlogTags
                .FirstOrDefaultAsync(b => b.Id == id);
            if (tag == null) return NotFound();
            // DataBase Select
            var blogsQuery = _dbContext.BlogToTags
                .Where(dr => dr.TagId == tag.Id)
                .Select(dr => new Blog
                {
                    Id= dr.Blog.Id,
                    Category = dr.Blog.Category,
                    Title = dr.Blog.Title,
                    Image =dr.Blog.Image,
                    PreviewDescription = dr.Blog.PreviewDescription,
                    Date = dr.Blog.Date,
                })
                .OrderByDescending(x => x.Date)
                .AsNoTracking().AsQueryable();

            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, page ?? 1, 15, "/BlogAsistant/BlogListBySubCategory/" + id.ToString());
            BlogListByTagVM blogListByTag = new()
            {
                Tag = tag,
                Blogs = blogs
            };
            return View(blogListByTag);
        }


        // Shearch Blog By Keyword GET
        [HttpGet]
        public async Task<IActionResult> BlogListByKeyword(string id, int? page)
        {

            string keyword = id;
            if(string.IsNullOrEmpty(keyword)) return NotFound();
            keyword=keyword.Trim();
            // DataBase Select
            var blogsQuery = _dbContext.Blogs
                .Where(dr => dr.Title.ToLower().Contains(keyword.ToLower()))
                .Include(x=>x.Category)
                .OrderByDescending(x => x.Date)
                .AsNoTracking().AsQueryable();

            var blogs = await PaginationList<Blog>.CreateAsync(blogsQuery, page ?? 1, 5, "/BlogAsistant/BlogListByKeyword/" + id.ToString());

            BlogListByKeywordVM blogListByKeyword = new()
            {
                Keyword = keyword,
                Blogs = blogs,
            };

            return View(blogListByKeyword);
        }

    }
}
