using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
    public class ProductAsistantController : Controller
    {
        private readonly StroykaDbContext _dbContext;
        public ProductAsistantController( StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

         


    }
}
