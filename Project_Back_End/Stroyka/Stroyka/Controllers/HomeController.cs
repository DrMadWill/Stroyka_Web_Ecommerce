using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Stroyka.Data;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StroykaDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, StroykaDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        // Product Index | GET
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IndexVM index = new()
            {
                // ========================== Header ===================

                //Full MegaCategories
                MegaCategories = await _dbContext.ProductMegaCategories.ToListAsync(),

                // Index Silder Data
                IndexSliders = await _dbContext.IndexSliders.ToListAsync(),

                // ============================ Content ================

                // Popular Algorithm Using Seals Tables But now not added
                PopularCategories = await _dbContext.ProductCategories
                .Include(x => x.SubCategories).Take(6).ToListAsync(),


                // Featured Product
                FeaturedProducts = await _dbContext.Products
                   .Where(dr => dr.Stars > 2) // Mumum Star : 3 
                   .OrderByDescending(x => x.Stars)
                   .Include(x => x.Status)
                   .ToListAsync(),

                // New Arrivals Product
                NewArrivals = (await _dbContext.Products
                .Include(x => x.Status)
                .Where(dr => dr.Date > DateTime.Now.AddMonths(-3))
                .ToListAsync()).GenarateNewArrivals(),

                // ============================== Footer ===============

                // Brands
                Brands = await _dbContext.ProductBrands.ToListAsync(),

                // Special Offers
                SpecialOffers = await _dbContext.Products
                .Where(dr=>dr.ProductDetail.IsSpecial) // Specail And Lastest
                .OrderByDescending(p=>p.Date)
                .Include(x => x.Status)
                .Take(3)
                .ToListAsync(),

                // Top Rated Product 
                RatedProducts = await _dbContext.Products
                .Include(x => x.Status)
                .Where(dr => dr.Stars > 3)// Mimum Star : 4
                .Take(3).ToListAsync(),

               
                
            };
            return View(index);
        }

        // Product Single | GET
        [HttpGet]
        public async Task<IActionResult> Single(int? id)
        {
            if (id == null) return ValidationProblem();

            var product = await _dbContext.Products
                .Include(x=>x.Brand)
                .Include(x=>x.ProductDetail).ThenInclude(x=>x.ProductImages)
                .FirstOrDefaultAsync(dr => dr.Id == id);
            if(product == null) return NotFound();

            var stocks = await _dbContext.ProductStock.Where(dr => dr.ProductId == id)
                .Include(x => x.Material).Include(x => x.Color)
                .ToListAsync();

            var stockMatrailAndColor = stocks.
                Select(x => new 
                    { x.MaterialId, MaterialName = x.Material.Name, Name = x.Color.Name,Id = x.ColorId ,Code= x.Color.Code,IsStock = x.Count >0 }
                );

            ViewBag.SessionStrig = JsonConvert.SerializeObject(stockMatrailAndColor);
            
            SingleVM single = new()
            {
                Product = product,
                Stocks = stocks,
                SubCategories = await _dbContext.SubCategoryToProducts
                .Include(x => x.SubCategory)
                .Where(x => x.ProductId == id).Select(x => x.SubCategory)
                .ToListAsync(),
                Reviews = await _dbContext.ProductReviews.Where(x => x.ProductId == id).Include(x=>x.User)
                .Take(5).ToListAsync(),
                Categories = await _dbContext.SubCategoryToProducts
                .Include(x=>x.SubCategory.Category)
                .Where(x=>x.ProductId == id).Select(x=>x.SubCategory.Category)
                .ToListAsync()
            };

            return View(single);
        }

        // Compare | GET
        [HttpGet]
        public async Task<IActionResult> Compare(string id)
        {
            var products = JsonConvert.DeserializeObject<List<CompareVM>>(id);
            foreach (var item in products)
            {
                item.Product = await _dbContext.Products
                   .Include(x => x.Status)
                   .Include(x => x.Brand)
                   .FirstOrDefaultAsync(x => x.Id == item.Id);

                if (item.Product == null) return NotFound();
            }
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
