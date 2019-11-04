using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        UserManager _users;

        public AccountController(UserManager userManager)
        {
            _users = userManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(UserModel model)
        {
            // ja izmanto reģistrācijas modeli:
            // ModelState.Remove("PasswordRepeat");
            if(ModelState.IsValid)
            {
                var user = _users.GetByEmailAndPassword(model.Email, model.Password);
                if(user == null)
                {
                    ModelState.AddModelError("error", "Invalid email/password!");
                }
                else
                {
                    HttpContext.Session.SetUserId(user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);

                    TempData["message"] = "You have successfully signed in!";
                    return RedirectToAction("Index", "Item");
                }
            }

            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if(ModelState.IsValid)
            {
                if(_users.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    _users.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                    });

                    TempData["message"] = "Account created!";
                    return RedirectToAction("SignIn");
                }
            }

            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Item");
        }
    }
}