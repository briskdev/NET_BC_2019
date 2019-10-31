using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsPortal.Logic;
using Microsoft.AspNetCore.Mvc;

namespace AdsPortal.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager manager = new CategoryManager();

        public CategoryController()
        {
            manager.Seed();
        }

        public IActionResult Index()
        {
            var categories = manager.GetAll();

            return View(categories);
        }
    }
}