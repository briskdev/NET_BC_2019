using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            var manager = new ItemManager();
            manager.Seed();

            var categoryManager = new CategoryManager();
            categoryManager.Seed();

            var items = manager.GetByCategory(id);
            var categories = categoryManager.GetAll();
            var model = new CatalogModel()
            {
                Items = items,
                Categories = categories,
            };

            return View(model);
        }
    }
}