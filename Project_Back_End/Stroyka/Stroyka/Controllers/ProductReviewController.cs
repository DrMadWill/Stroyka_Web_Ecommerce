using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Products;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Controllers
{
    public class ProductReviewController : Controller
    {

        private readonly StroykaDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        public ProductReviewController(StroykaDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(Review review)
        {
            if (!ModelState.IsValid) return Json(new { status = 422 });
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new { status = 403 });

            review.UserId = user.Id;
            review.Date = DateTime.Now;
            
            await _dbContext.ProductReviews.AddAsync(review);
            await _dbContext.SaveChangesAsync();

            return Json(new { status = 201});
        }


        [HttpGet]
        public async Task<JsonResult> LoadMore(int? id,int page)
        {
            if (id == null) return Json(new { status = 422 });

            var reviews = await _dbContext.ProductReviews
                .Where(x => x.ProductId == id)
                .Skip(Math.Abs(page - 1) * 5)
                .Take(5)
                .Select(x=>new
                {
                    x.Stars,
                    x.Content,
                    x.Date,
                    x.User.UserName,
                    x.User.Image
                })
                .ToListAsync();
            
            return Json(reviews);
        }


    }
}
