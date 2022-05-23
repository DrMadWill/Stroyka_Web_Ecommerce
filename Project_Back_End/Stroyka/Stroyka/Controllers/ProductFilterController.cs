using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Products;
using Stroyka.ViewModels;
using Stroyka.ViewModels.AjaxModels;
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
           
            if (id == null)
            {
               var newArrivalsProductDefault = await _dbContext.Products
               .Where(dr => dr.Stars > 2)
               .OrderByDescending(x => x.Stars)
               .Select(dr => new ProductAM
               {
                   Name = dr.Name,
                   CurrentPrice = dr.CurrentPrice,
                   Date = dr.Date,
                   OldPrice = dr.OldPrice,
                   Id = dr.Id,
                   Image = dr.Image,
                   Stars = dr.Stars,
                   Status = new Status { Name = dr.Status.Name },
                   ReviewsCount = dr.Reviews.Count
               })
               .ToListAsync();
                return Json(newArrivalsProductDefault);
            }
            var newArrivalsProduct = await _dbContext.SubCategoryToProducts
                   .Where(dr => dr.SubCategory.Category.MegaCategory.Id == id && dr.Product.Stars > 2)
                   .OrderByDescending(x => x.Product.Stars)
                   .Include(x => x.Product)
                   .Select(dr => new ProductAM
                   {
                       Name = dr.Product.Name,
                       CurrentPrice = dr.Product.CurrentPrice,
                       Date = dr.Product.Date,
                       OldPrice = dr.Product.OldPrice,
                       Id = dr.Product.Id,
                       Image = dr.Product.Image,
                       Stars = dr.Product.Stars,
                       Status = new Status { Name = dr.Product.Status.Name },
                       ReviewsCount = dr.Product.Reviews.Count
                   })
                   
                  .ToListAsync();
           
            return Json(newArrivalsProduct);
        }

        // Qucik View | GET
        [HttpGet]
        public async Task<JsonResult> Quickview(int? id)
        {
            if (id == null) return Json(new { status = 422 });

            var stock = _dbContext.ProductStock
                .Where(dr => dr.ProductId == id)
                .AsQueryable();

            var material = await stock
               .Select(x => new MaterialAM { Id = x.Material.Id, Name = x.Material.Name })
               .ToListAsync();
            material = MyList<MaterialAM, int>.DublicateDelete(material);


            var materialColors = await DatabaseSelectColor(stock, material);

            var product = await _dbContext
                .Products
                .Include(x => x.ProductDetail)
                .Select(dr => new
                {
                    Name = dr.Name,
                    CurrentPrice = dr.CurrentPrice,
                    Date = dr.Date,
                    OldPrice = dr.OldPrice,
                    Id = dr.Id,
                    Image = dr.Image,
                    Materials = materialColors,
                    Brand = new { dr.Brand.Id, dr.Brand.Name },
                    IsInStock = dr.IsInStock,
                    Stars = dr.Stars,
                    Status = new { dr.Status.Id, dr.Status.Name },
                    ReviewsCount = dr.Reviews.Count,
                    ProductDetail = new
                    {
                        dr.ProductDetail.SKU,
                        dr.MiniDecription,
                        Colors = dr.Stocks.Select(x => new { x.Color.Id, x.Color.Name, IsStock = x.Count > 0 }),
                        Galery = dr.ProductDetail.ProductImages.Select(x => x.Name)
                    },
                    SubCategories = dr.SubCategoryToProducts.Select(sr => new { sr.SubCategory.Id, sr.SubCategory.Name }),
                    Categories = dr.SubCategoryToProducts.Select(st => new { st.SubCategory.Category.Id, st.SubCategory.Category.Name })
                })
                .FirstOrDefaultAsync(dr => dr.Id == id);

            if (product == null) return Json(new { status = 404 });

            return Json(product);
        }

        private async Task<List<MaterialAM>> DatabaseSelectColor(IQueryable<Stock> stocks, List<MaterialAM> materials)
        {
            foreach (var item in materials)
            {
                item.ColorAMs = await stocks.Where(dr => dr.MaterialId == item.Id)
                    .Select(x => new ColorAM { Id = x.ColorId, Name = x.Color.Name, Code = x.Color.Code, IsStock = x.Count > 0 })
                    .ToListAsync();
            }
            return materials;
        }

        


    }
}
