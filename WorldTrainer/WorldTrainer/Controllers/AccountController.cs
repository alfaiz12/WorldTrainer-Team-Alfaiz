using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace WorldTrainer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository repo;
        public AccountController(IRepository myrepo)
        {
            repo = myrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Models.TrainerModel trainer)
        {
            var data = repo.GetTrainers(trainer.TrainerEmail, trainer.TrainerPassword);
            if (data != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,trainer.TrainerEmail)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var id = data.TrainerId;
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("Email", trainer.TrainerEmail, option);
                CookieOptions option1 = new CookieOptions();
                option1.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("Id", id.ToString(), option1);
                return RedirectToAction("Profile","TrainerController1");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            
        }

        public async Task<IActionResult> Logout()
        {
            if (Request.Cookies["Email"] != null)
            {
                Response.Cookies.Delete("Email");
            }
            if (Request.Cookies["Id"] != null)
            {
                Response.Cookies.Delete("Id");
            }
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
      
    }
}
