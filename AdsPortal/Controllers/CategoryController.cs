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
        private CategoryManager _manager;

        public CategoryController(CategoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var categories = _manager.GetAllWithAdCount();

            return View(categories);
        }
    }
}