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
        AdManager _manager;
        CategoryManager _categoryManager;

        public AdController(AdManager manager, CategoryManager categoryManager)
        {
            _manager = manager;
            _categoryManager = categoryManager;
        }
        
        public IActionResult Index(int id)
        {
            var ads = _manager.GetByCategory(id);

            return View(ads);
        }

        public IActionResult View(int id)
        {
            var ad = _manager.Get(id);

            return View(ad);
        }

        public IActionResult Create()
        {
            AdModel model = new AdModel();

            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = _categoryManager.GetAll();

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