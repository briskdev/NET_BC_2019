using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsPortal.Logic;
using AdsPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdsPortal.Controllers
{
    public class AdController : Controller
    {
        AdManager manager = new AdManager();

        public AdController()
        {
            manager.Seed();
        }
        
        public IActionResult Index(int id)
        {
            var ads = manager.GetByCategory(id);

            return View(ads);
        }

        public IActionResult View(int id)
        {
            var ad = manager.Get(id);

            return View(ad);
        }

        public IActionResult Create()
        {
            AdModel model = new AdModel();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Seed();
            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = categoryManager.GetAll();

            return View(model);
        }
        
        [HttpPost]
        public IActionResult Create(AdModel model)
        {
            if(ModelState.IsValid)
            {
                // TODO: ieraksta saglabāšana
            }

            return View(model);
        }
    }
}