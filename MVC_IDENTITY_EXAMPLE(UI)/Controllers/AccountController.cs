using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Service.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Identity;
using MVC_IDENTITY_EXAMPLE_UI_.Models;

namespace MVC_IDENTITY_EXAMPLE_UI_.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager, IEmailSender emailSender)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._emailSender = emailSender;
        }

        [HttpGet]
        public async Task<IActionResult> Register(string returnUrl = "") => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = "")
        {
            if (!TryValidateModel(model)) return StatusCode(500);

            var user = new User() { Email = model.Login, UserName = model.Login };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded) return StatusCode(500);

            if (await _roleManager.FindByNameAsync("user") == null)
            {
                var role = await _roleManager.CreateAsync(new Role() { Name = "user" });
                if (role.Succeeded)
                    await _userManager.AddToRoleAsync(user, "user");
            }
            else await _userManager.AddToRoleAsync(user, "user");

            await _signInManager.SignInAsync(user, false);

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var link = Url.Action("Confirm", "Account",
                new { guid = token, userEmail = user.Email }, Request.Scheme, Request.Host.Value);
            await _emailSender.SendEmailAsync(user.Email, "Link ->>>", link);

            return Redirect("/home/index");

        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = "") => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = "")
        {
            if (!TryValidateModel(model)) return StatusCode(500);

            var result = await _signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Book");
            }
            return StatusCode(500);

        }


        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Logout(string returnUrl = "")
        {
            await _signInManager.SignOutAsync();

            if (returnUrl == "/")
                return RedirectToAction("Index", "Home");

            else if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return new EmptyResult();

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPasswordAsync(string userEmail)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var link = Url.Action("ChangePassword", "Account",
                new { guid = token, userEmail = user.Email }, Request.Scheme, Request.Host.Value);
            await _emailSender.SendEmailAsync(user.Email, "Link ->>>", link);

            // add Send View 
            return Redirect("/home/index");

        }

        [HttpGet]
        public async Task<IActionResult> ChangePasswordAsync(string userEmail, string guid)
        {
            return await Task.Run(() => View(new ResetPasswordViewModel() { Email = userEmail, Guid = guid }));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmResetPasswordAsync(ResetPasswordViewModel model)
        {
            if (!TryValidateModel(model)) return View();

            var user = await _userManager.FindByEmailAsync(model.Email);
            var res = await _userManager.ResetPasswordAsync(user, model.Guid, model.Password);
            //todo add view changePassword Success
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmAsync(string guid, string userEmail)
        {
            var user = await _userManager.FindByEmailAsync(email: userEmail);
            var res = await _userManager.ConfirmEmailAsync(user, guid);
            if (res.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            //todo add ERROR PAGE
            return View();
        }
    }


}
