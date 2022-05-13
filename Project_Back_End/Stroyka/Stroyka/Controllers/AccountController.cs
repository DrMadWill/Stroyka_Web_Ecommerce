using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Blogs;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Controllers
{
    public class AccountController : Controller
    {
        private readonly StroykaDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        public AccountController(StroykaDbContext dbContext, UserManager<User> userManager,
                                RoleManager<IdentityRole> roleManager,
                                SignInManager<User> signInManager, IEmailService emailService)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailService = emailService;

        }

        // ======================= Login ============
        // Login Get
        [HttpGet]
        public IActionResult Login()
        {
            SignInVM signIn = new();
            return View(signIn);
        }

        // Login Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignInVM signIn)
        {

            if (!ModelState.IsValid) return View(signIn);
            // Check User 
            var user = await _userManager.FindByEmailAsync(signIn.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Email is Wrong!");
                return View(signIn);
            }
            // Check Pass 
            var resault = await _signInManager.PasswordSignInAsync(user, signIn.Password, signIn.RememberMe, false);
            if (resault.Succeeded)
            {
                await _signInManager.SignInAsync(user, true);
                return Redirect("/");
            }
            ModelState.AddModelError("Password", "Password Wrong!");
            return View(signIn);
        }


        // ======================== Logout ======================
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }


        // ======================= Register ============
        // Register GET
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.IsShowing = false;
            SignUpVM sign = new SignUpVM();
            return View(sign);
        }

        // Register Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignUpVM sign)
        {

            ViewBag.IsShowing = false;
            if (!ModelState.IsValid) return View(sign);

            // Check User Name Unique 
            var userTest = await _userManager.FindByNameAsync(sign.UserName);
            if (userTest != null)
            {
                ViewBag.IsShowing = true;
                ModelState.AddModelError(string.Empty, "User Name Already Used.");
                return View(sign);
            }


            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(_userManager, null, sign.Password);
            if (!result.Succeeded)
            {
                ViewBag.IsShowing = true;
                foreach (var item in result.Errors)
                    ModelState.AddModelError(string.Empty, item.Description);
                return View(sign);
            }


            // Check Email Unique And Anouther Opertion
            if (_userManager.FindByEmailAsync(sign.Email).Result == null)
            {
                User user = new User
                {
                    Image = "profil.png",
                    Email = sign.Email,
                    UserName = sign.UserName,
                    Gender = sign.Gender
                };
                IdentityResult resault = await _userManager.CreateAsync(user, sign.Password);
                if (resault.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role: "User");
                    await _dbContext.SaveChangesAsync();

                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("UserAdmin");
                }
            }
            else
            {
                ViewBag.IsShowing = true;
                ModelState.AddModelError("Email Error", "This Email Already Using");
                return View(sign);

            }
            ViewBag.IsShowing = true;
            ModelState.AddModelError("Error", "Sorry. Account Not Created.");
            return View(sign);
        }

        

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            ForgetPasswordVM forgetPassword = new ForgetPasswordVM();
            return View(forgetPassword);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPassword)
        {
            if (!ModelState.IsValid) return View(forgetPassword);

            var user = await _userManager.FindByEmailAsync(forgetPassword.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Don't Find This Email.");
                return View(forgetPassword);
            }

            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string url = Url.Action("ResetPassword", "Signin", new { token, email = user.Email }, Request.Scheme);

            string body = string.Empty;
            using (StreamReader reader = new("wwwroot/templates/forgetpasswod.html"))
                body = reader.ReadToEnd();

            body = body.Replace("{{url}}", url);

            _emailService.Send(user.Email, "Reset Password", body);

            return Redirect("/Signin/Login");
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email)) return Redirect("/System/Error404");
            ResetPasswordVM resetPassword = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetPassword);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            if (!ModelState.IsValid) return View(resetPassword);

            // Check User 
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);
            if (user == null) return Redirect("/System/Error404");

            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(_userManager, null, resetPassword.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Password", result.Errors.First().Description);
                return View(resetPassword);
            }

            var resault = await _userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);

            if (resault.Succeeded)
            {
                return Redirect("/");
            }
            ModelState.AddModelError("Password", "We Have Some Problem");
            return View(resetPassword);
        }

    }
}
