using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsPortal.Logic;
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
            return View();
        }
    }
}