using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
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
                var manager = new UserManager();
                var user = manager.GetByEmailAndPassword(model.Email, model.Password);
                if(user == null)
                {
                    ModelState.AddModelError("error", "Invalid email/password!");
                }
                else
                {
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
                UserManager manager = new UserManager();

                if(manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
              
                    manager.Create(new Logic.User()
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
    }
}