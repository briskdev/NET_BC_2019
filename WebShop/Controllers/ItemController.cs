using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            var manager = new ItemManager();
            manager.Seed();

            var items = manager.GetByCategory(2);

            return View(items);
        }
    }
}