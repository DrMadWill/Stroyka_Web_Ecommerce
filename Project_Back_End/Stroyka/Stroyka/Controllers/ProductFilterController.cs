using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Products;
using Stroyka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Controllers
{
    
    public class ProductFilterController : Controller
    {
        private readonly StroykaDbContext _dbContext;
        public ProductFilterController(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<JsonResult> NewArrivals(int? id)
        {
            if (id == null) return Json(new { Status = 422 });
            List<Product> newArrivalsProduct = null;
            var date = DateTime.Now.AddMonths(-3);
            if (id == 0)
            {
                newArrivalsProduct = await _dbContext.SubCategoryToProducts
                .Where(dr =>dr.Product.Date > date)
                .Include(x => x.Product)
                .Select(dr => dr.Product)
                .ToListAsync();
            }
            else
            {
                newArrivalsProduct = await _dbContext.SubCategoryToProducts
                .Where(dr => dr.SubCategory.Category.MegaCategory.Id == id && dr.Product.Date > date)
                .Include(x => x.Product)
                .Select(dr => new Product 
                { 
                    Name = dr.Product.Name,
                    CurrentPrice = dr.Product.CurrentPrice,
                    Date = dr.Product.Date,
                    OldPrice = dr.Product.OldPrice,
                    Id = dr.Product.Id,
                    Image = dr.Product.Image,
                    IsInStock = dr.Product.IsInStock,
                    Stars = dr.Product.Stars,
                    Status = new Status { Name = dr.Product.Status.Name},
                })
                .ToListAsync();
            }
            return Json(newArrivalsProduct.GenarateNewArrivals());
        }
    }
}
