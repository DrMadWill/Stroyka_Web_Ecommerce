using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Stroyka.Models;

namespace Stroyka.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{status}")]
        public IActionResult HttpStatusCodeHandler(int status)
        {
            ErrorViewModel errorVM = new()
            {
                Description = string.Empty,
                StatusCode = status
            };

            return View(errorVM);
        }





    }
}
