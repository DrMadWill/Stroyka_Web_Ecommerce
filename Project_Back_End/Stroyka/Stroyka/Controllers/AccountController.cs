using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stroyka.Data;
using Stroyka.Extensions;
using Stroyka.Models;
using Stroyka.Models.Blogs;
using Stroyka.Models.Users;
using Stroyka.ViewModels;
using System;
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
        public IActionResult Login(string ReturnUrl = "")
        {
            SignInVM signIn = new()
            {
                ReturnUrl = ReturnUrl
            };
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

                if (string.IsNullOrEmpty(signIn.ReturnUrl))
                {
                    return Redirect("/");
                }
                return Redirect(signIn.ReturnUrl);

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

        // ======================== Access Denied ===============

        public async Task<IActionResult> AccessDenied() => View();


        // ======================= Register ============
        // Register | GET
        [HttpGet]
        public IActionResult Register()
        {
            SignUpVM sign = new();
            return View(sign);
        }

        // Register | POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignUpVM sign)
        {

            if (!ModelState.IsValid) return View(sign);


            // Genrate User Name Unique 
            UserNameCreate:
            Random random = new Random();
            sign.UserName = sign.FullName.ToLower().Trim().Replace(" ", "") + random.Next(1000,9999); 
            var userTest = await _userManager.FindByNameAsync(sign.UserName);
            if (userTest != null) goto UserNameCreate;
           


            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(_userManager, null, sign.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                    ModelState.AddModelError("Password", item.Description);
                return View(sign);
            }


            // Check Email Unique And Anouther Opertion
            if (_userManager.FindByEmailAsync(sign.Email).Result == null)
            {
                User user = new User
                {
                    Image = "profil.png",
                    PhoneNumber = sign.PhoneNumber,
                    FullName = sign.FullName,   
                    Age = (byte)(DateTime.Now.Year - sign.Age),
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
                    return Redirect("/");
                }
                else
                {
                    TempData["AccountErrorMessage"] = "Sorry.Plase Try Agein.";
                    return View(sign);
                }
            }
            else
            {
                ModelState.AddModelError("Email", "This Email Already Using");
                return View(sign);
            }
        }

        //========================= Forget Password ====
        // Forget Password | GET
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            ForgetPasswordVM forgetPassword = new();
            return View(forgetPassword);
        }

        // Forget Password | POST
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
            string url = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

            string body = string.Empty;
            using (StreamReader reader = new("wwwroot/templates/forgetpasswod.html"))
                body = reader.ReadToEnd();

            body = body.Replace("{{url}}", url);
            _emailService.Send(user.Email, "Reset Password", body);

            return RedirectToAction("/Login");
        }

        //========================= Reset Password ====
        // Reset Password | GET
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email)) return NotFound();
            ResetPasswordVM resetPassword = new()
            {
                Token = token,
                Email = email
            };
            return View(resetPassword);
        }

        // Reset Password | POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            if (!ModelState.IsValid) return View(resetPassword);

            // Check User 
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);
            if (user == null) return NotFound();

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
                return RedirectToAction("Login");

            ModelState.AddModelError("Password", "We Have Some Problem");
            return View(resetPassword);
        }

    }
}
