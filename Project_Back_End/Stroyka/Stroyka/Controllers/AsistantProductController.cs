using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Stroyka.Controllers
{
    public class AsistantProductController : Controller
    {
        private readonly StroykaDbContext _dbContext;
        public AsistantProductController( StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<JsonResult> NewArrivals(int? id)
        {
            if (id == null) return Json(new { Status = 404 });
            var date = DateTime.Now.AddMonths(-3);

            var newArrivalsProduct =await  _dbContext.SubCategoryToProducts
                .Where(dr=>dr.SubCategory.Category.MegaCategory.Id == id && dr.Product.Date > date)
                .Include(x => x.Product)
                .Select(dr => dr.Product)
                .ToListAsync();
            return Json(newArrivalsProduct.GenarateNewArrivals());
        }
    }
}
