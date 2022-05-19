using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Data;
using Stroyka.Models.Blogs;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using Stroyka.ViewModels.AjaxModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Controllers
{
    public class BlogCommentController : Controller
    {
        private readonly StroykaDbContext _dbContext;
        private readonly UserManager<User> userManager;

        public BlogCommentController(StroykaDbContext dbContext, UserManager<User> _userManager)
        {
            _dbContext = dbContext;
            userManager = _userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(Comment commentu)
        {
         
            if (string.IsNullOrWhiteSpace(User.Identity.Name)) return Json(new
            {
                status = 403
            });

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new
            {
                status = 403
            });

            commentu.UserId = user.Id;


            // Model Validation
            if (!ModelState.IsValid) return Json(new
            {
                status = 422
            });

            // Leave Comment
            if (commentu.ParentId == null)
            {
                var blog = await _dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id == commentu.BlogId);
                if (blog == null) return Json(new
                {
                    status = 404
                });
                commentu.IsChild = false;
                commentu.BlogId = blog.Id;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;
                await _dbContext.BlogComments.AddAsync(commentu);
                await _dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
            // Replay Comment
            else
            {
                var commentParent = await _dbContext.BlogComments
                    .FirstOrDefaultAsync(dr => dr.Id == commentu.ParentId);
                if (commentParent == null) return Json(new
                {
                    status = 404
                });

                //Is Chaild True
                commentParent.IsChild = true;


                commentu.ParentId = commentParent.Id;
                commentu.BlogId = commentParent.BlogId;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;
                commentu.UserId = user.Id;

                await _dbContext.BlogComments.AddAsync(commentu);
                await _dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
        }

        

        [HttpGet]
        public async Task<JsonResult> GetMoreComment(int? blogId, int? commentSectionIndex)
        {

            if (blogId == null) return Json(new { status = 422 });

            var blog = await _dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id == blogId);
            if (blog == null) return Json(new { status = 404 });

            // DataBase Count 
            int count = await _dbContext.BlogComments.CountAsync();
            // CommentSize
            int commentSize = 5;

            int maxSize = (int)Math.Ceiling(count / (double)commentSize);
            if (commentSectionIndex > maxSize) return Json(new { status = 404 });

            // Defaul Number
            if (commentSectionIndex == 0 || commentSectionIndex < 0) commentSectionIndex = 1;
            int index = commentSectionIndex ?? 1;
            var comments = await _dbContext.BlogComments
                .Where(dr => dr.BlogId == blog.Id && dr.IsBlocked == false && dr.ParentId == null)
                .Select(x => new
                {
                    x.Id,
                    x.IsChild,
                    x.ParentId,
                    x.BlogId,
                    x.Description,
                    x.Date,
                    x.HtmlId,
                    x.User.FullName,
                    x.User.Image
                })
                .Skip(Math.Abs(index - 1) * commentSize).Take(commentSize).ToListAsync();
            return Json(comments);
        }

        [HttpGet]
        public async Task<JsonResult> GetChildComment(int? parentId, int? index)
        {
            if (parentId == null) return Json(new { status = 404 });
            int cIndex = index ?? 1;

            var comments = await _dbContext.BlogComments
                .Where(dr => dr.ParentId == parentId && dr.IsBlocked == false)
                .Select(x => new CommentAM
                {
                    Id = x.Id,
                    IsChild = x.IsChild,
                    ParentId = x.ParentId,
                    BlogId = x.BlogId,
                    Description = x.Description,
                    Date = x.Date,
                    HtmlId = x.HtmlId,
                    FullName = x.User.FullName,
                    Image = x.User.Image,
                    ParentUserName = x.Parent.User.UserName
                })
                .Skip((cIndex - 1) * 5).Take(5).ToListAsync();
            return Json(comments);
        }
    }
}
