using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models;
using Stroyka.ViewModels.ViewComponentModels;
using System;
using Stroyka.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stroyka.Models.Products;
using Stroyka.Models.SqlFuncion;

namespace Stroyka.ViewComponents
{
    public class SearchSideBarViewComponent:ViewComponent
    {
        private readonly StroykaDbContext _dbContext;

        public SearchSideBarViewComponent(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var megaCategory = await _dbContext.ProductMegaCategories.FirstOrDefaultAsync(dr=>dr.Id == id);
            var categoies = await _dbContext.ProductCategories
                .Where(x=>x.MegaCategoryId == id).Include(_ => _.SubCategories).ToListAsync();
            megaCategory.Categories = categoies;

            MaxMinPriceByMegaCategory maxmin;
            try
            {
                maxmin = await _dbContext.MaxMinPriceByMegaCategories
                .FromSqlRaw($"select * from udfMinMaxPriceByMegaCategory({id})")
                .FirstOrDefaultAsync();
            }
            catch
            {
                maxmin = new() { MaxPrice = 1, MinPrice = 0 };
            }

            var date = DateTime.Now.AddMonths(-3);
            if(maxmin.MaxPrice == maxmin.MinPrice)
            {
                maxmin.MaxPrice++;
            }

            ProductListSideBarVM sideBar = new()
            {
                MegaCategory = megaCategory,
                Products = await _dbContext.Products.Where(dr => dr.Date > date).Take(5).ToListAsync(),
                Colors = await _dbContext.ProductColors
                .FromSqlRaw("EXECUTE  us_ColorForMegaCategory @id=" + id)
                .ToListAsync(),
                Brands = await _dbContext.BrandStocks
                .FromSqlRaw("EXECUTE  us_BrandForMegaCategory @id =" + id)
                .ToListAsync(),
                MaxPrice = maxmin.MaxPrice,
                MinPrice = maxmin.MinPrice,
                Materials = await _dbContext.ProductMaterials
                .FromSqlRaw("EXECUTE us_MaterialByMegaCategory @id =" + id)
                .ToListAsync()
            };
            return View(sideBar);
        }
    }
}
