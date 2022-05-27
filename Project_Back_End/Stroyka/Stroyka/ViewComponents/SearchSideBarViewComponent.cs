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

            var colors = await _dbContext.ProductColors
                .FromSqlRaw("EXECUTE  us_ColorForMegaCategory @id=" + id)
                .ToListAsync();

            var brand = await _dbContext.ProductBrands
                .FromSqlRaw("EXECUTE  us_BrandForMegaCategory @id =" + id)
                .ToListAsync();

            //var prod = await _dbContext.Products
            //    .FromSqlRaw("EXECUTE  us_MaxMinPriceForMegaCategory @id =" + id)
            //    .ToListAsync();


            //var maxmin = prod.Select(x => new { MaxPrice = x.CurrentPrice, MinPrice = x.OldPrice ?? 0 }).FirstOrDefault(); /*new { MaxPrice = prod.CurrentPrice, MinPrice = prod.OldPrice ?? 0 };*/
            var barnd =  await _dbContext.BrandStocks
                .FromSqlRaw("EXECUTE  us_BrandForMegaCategory @id =" + id)
                .ToListAsync();

            var date = DateTime.Now.AddMonths(-3);

            ProductListSideBarVM sideBar = new()
            {
                MegaCategory = megaCategory,
                Products = await _dbContext.Products.Where(dr => dr.Date > date).Take(5).ToListAsync(),
                Colors = colors,
                Brands = barnd,
                //MaxPrice = maxmin.MaxPrice,
                //MinPrice = maxmin.MaxPrice
            };
            return View(sideBar);
        }
    }
}
