using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            IndexVM index = new IndexVM
            {
                IndexSliders = await _dbContext.IndexSliders.ToListAsync(),
                // Popular Algorithm Using Seals Tables But now not added
                Categories = await _dbContext.Categories.Include(x=>x.SubCategories).Take(6).ToListAsync()
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
