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

        // For Index New Arrivals Product Carusel | GET

        [HttpGet]
        public async Task<JsonResult> NewArrivals(int? id)
        {
            var date = DateTime.Now.AddMonths(-3);
            List<Product> newArrivalsProduct = null;
            if (id == null)
            {
                 newArrivalsProduct = await _dbContext.SubCategoryToProducts
                .Where(dr => dr.Product.Date > date)
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
                    Status = new Status { Name = dr.Product.Status.Name },
                    ReviewsCount = dr.Product.Reviews.Count
                })
                .ToListAsync();

                return Json(newArrivalsProduct.GenarateNewArrivals());
            }
          
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
                Status = new Status { Name = dr.Product.Status.Name },
                ReviewsCount = dr.Product.Reviews.Count
            })
            .ToListAsync();

            return Json(newArrivalsProduct.GenarateNewArrivals());
        }

        //For Index Featured Product Carusel | GET

        [HttpGet]
        public async Task<JsonResult> Featured(int? id)
        {
            List<Product> newArrivalsProduct = null;
            if (id == null)
            {
                newArrivalsProduct = await _dbContext.SubCategoryToProducts
               .Where(dr => dr.Product.Stars > 3)
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
                   Status = new Status { Name = dr.Product.Status.Name },
                   ReviewsCount = dr.Product.Reviews.Count
               })
               .ToListAsync();
                return Json(newArrivalsProduct);
            }

            newArrivalsProduct = await _dbContext.SubCategoryToProducts
            .Where(dr => dr.SubCategory.Category.MegaCategory.Id == id && dr.Product.Stars > 3)
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
                Status = new Status { Name = dr.Product.Status.Name },
                ReviewsCount = dr.Product.Reviews.Count
            })
           .ToListAsync();
            return Json(newArrivalsProduct);
        }
    }
}
