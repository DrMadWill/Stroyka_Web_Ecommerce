using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models.Blogs;
using Stroyka.Models.Commoun;
using Stroyka.ViewModels;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Stroyka.Controllers
{
    public class BlogAsistantController : Controller
    {

        private readonly StroykaDbContext _dbContext;
        public BlogAsistantController(StroykaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        // Blog Subscribe  GET
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult> BlogSubscribe(string email)
        {
            // Validator
            email = email.Trim();
            var resault = Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!resault) return Json(new { status = 422 });// Is Not Vaild

            // Database Chack : IsAlready Added
            var emailDb = await _dbContext.EmailForSubscribes.FirstOrDefaultAsync(dr => dr.Email.ToLower() == email.ToLower());
            if (emailDb != null) return Json(new { status = 409 });// DataBase Conflict
            
            // Creeate New DataBase
            EmailForSubscribe  newEmailForSubscribe = new() { Email = email,IsBlog=true,IsProduct=false };
            await _dbContext.EmailForSubscribes.AddAsync(newEmailForSubscribe);
            await _dbContext.SaveChangesAsync();
            return Json(new { status = 201});
        }
    }
}
