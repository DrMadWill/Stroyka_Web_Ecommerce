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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StroykaDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, StroykaDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            IndexVM index = new()
            {
                // Index Silder Data
                IndexSliders = await _dbContext.IndexSliders.ToListAsync(),
                // Popular Algorithm Using Seals Tables But now not added
                PopularCategories = await _dbContext.Categories.Include(x=>x.SubCategories).Take(6).ToListAsync(),
                // Top Rated Product 
                RatedProducts = await _dbContext.Products
                .Include(x=>x.Reviews)
                .Include(x=>x.Status)
                .Where(dr=>dr.Stars > 3).Take(3).ToListAsync(),
                //Full MegaCategories
                MegaCategories = await _dbContext.MegaCategories.ToListAsync(),
                // New Arrivals Product
                NewArrivals = (await _dbContext.Products
                .Include(x => x.Reviews)
                .Include(x => x.Status)
                .Where(dr => dr.Date > DateTime.Now.AddMonths(-3))
                .ToListAsync()).GenarateNewArrivals()
            };
            return View(index);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
