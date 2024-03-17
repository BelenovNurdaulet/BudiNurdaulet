using Budi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;




namespace Budi.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();

        }


        //[HttpPost]
        //public async Task<IActionResult> Index(string login, string password, string ReturnUrl)
        //{
        //    if (login == "admin" && password == "admin")
        //    {
        //        // Перенаправление на другую страницу после успешной аутентификации
        //        return RedirectToAction("Index", "Home");
        //    }

        //    // В случае неверных учетных данных возвращаемся на страницу входа
        //    ModelState.AddModelError(string.Empty, "Неверный логин или пароль.");
        //    return View();
        //}


        [HttpPost]
        public async Task<IActionResult> Index(string login, string password, string returnUrl)
        {
            if (login == "admin" && password == "admin")
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, login)
        };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true // Сделать аутентификацию постоянной
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Redirect(returnUrl);
                }
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль.");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }



    }
}

