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
        AdManager _ads;
        CategoryManager _categories;

        public AdController(AdManager manager, CategoryManager categoryManager)
        {
            _ads = manager;
            _categories = categoryManager;
        }
        
        public IActionResult Index(int id)
        {
            AdListModel model = new AdListModel()
            {
                // sludinājumi kategorijā
                Ads = _ads.GetByCategory(id),
                // atvērtās kategorijas dati
                Category = _categories.Get(id)
            };

            return View(model);
        }

        public IActionResult View(int id)
        {
            var ad = _ads.GetWithCategory(id);

            return View(ad);
        }

        public IActionResult Create()
        {
            AdModel model = new AdModel();

            // lietotāja e-pasts no profila
            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = _categories.GetAll();

            return View(model);
        }
        
        [HttpPost]
        public IActionResult Create(AdModel model)
        {
            if(ModelState.IsValid)
            {
                var ad = new Ad()
                {
                    CategoryId = model.CategoryId,
                    CreatedOn = DateTime.Now,
                    Description = model.Description,
                    Email = model.Email,
                    Location = model.Location,
                    Price = model.Price,
                    Telephone = model.Telephone,
                    Title = model.Title,
                    Photo = model.Photo
                };

                _ads.Create(ad);

                // ja viss OK, pārsūtām uz sludinājumu sadaļu
                return RedirectToAction(nameof(Index), new { id = model.CategoryId });
            }

            // kategorijas nepieciešams atlasīt arī POST pieprasījumā
            model.Categories = _categories.GetAll();
            return View(model);
        }
    }
}