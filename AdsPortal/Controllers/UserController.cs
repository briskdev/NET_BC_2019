using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsPortal.Logic;
using AdsPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdsPortal.Controllers
{
    public class UserController : Controller
    {
        UserManager _users;
        AdManager _ads;

        public UserController(UserManager manager, AdManager adManager)
        {
            _users = manager;
            _ads = adManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(UserModel model)
        {
            if(ModelState.IsValid)
            {
                var user = _users.GetByEmailAndPassword(model.Email, model.Password);
                if(user == null)
                {
                    ModelState.AddModelError("error", "Nekorekts e-pasts un/vai parole!");
                }
                else
                {
                    HttpContext.Session.SetUserId(user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);

                    return RedirectToAction("Index", "Category");
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
                    ModelState.AddModelError("error", "Šāds e-pasts jau eksistē!");
                }
                else
                {
              
                    _users.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                    });

                    TempData["message"] = "Konts izveidots!";
                    return RedirectToAction("SignIn");
                }
            }

            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Category");
        }

        public IActionResult MyAds()
        {
            var ads = _ads.GetByUser(HttpContext.Session.GetUserEmail());

            return View(ads);
        }
    }
}