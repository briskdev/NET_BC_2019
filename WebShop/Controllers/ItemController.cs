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
        private CategoryManager _categories;
        private ItemManager _items;

        public ItemController(CategoryManager categoryManager, ItemManager itemManager)
        {
            _categories = categoryManager;
            _items = itemManager;

            // categoryManager tiek aizpildīts no Dependency Injection
            // _categories ir pieejams visas klases ietvaros
        }

        public IActionResult Index(int id)
        {
            var items = _items.GetByCategory(id);
            var categories = _categories.GetAll();
            foreach(Category cat in categories)
            {
                // ... atlasa un uzstādā preču skaitu zem konkrētās kategorijas
                cat.ItemCount = _items.GetByCategory(cat.Id).Count;
            }

            var model = new CatalogModel()
            {
                Items = items,
                Categories = categories,
            };

            return View(model);
        }

        // 1. Pievieno jaunu darbību Buy ar vienu parametru - id;
        // 2. Atlasa lietotāja grozu no sesijas:
        // 2.1. Ja grozs nav definēts, definē grozu kā jaunu sarakstu (new List<int>());
        // 3. Pievieno izvēlēto preces ID lietotāja grozam;
        // 4. Saglabā lietotāja grozu sesijā.
        public IActionResult Buy(int id)
        {
            var item = _items.Get(id);

            var basket = HttpContext.Session.GetUserBasket();
            if(basket == null)
            {
                basket = new List<int>();
            }
            basket.Add(id);

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Index", "Item", new { id = item.CategoryId });
        }

        public IActionResult Basket()
        {
            // 1. Definē jaunu sarakstu precēm;
            List<Item> items = new List<Item>();
            List<int> basket = HttpContext.Session.GetUserBasket();
            if (basket != null)
            {
                // 2. Par katru preci, kas ir lietotāja sesijā atlasa tās datus 
                //    un pievieno sarakstam; 
                foreach(var id in basket)
                {
                    items.Add(_items.Get(id));
                }
            }
            // 3. Atgriež preču sarakstu uz View
            return View(items);
        }

        public IActionResult Delete(int id)
        {
            // 1. Dzēš preci no groza
            // 2. Atjauno datus sesijā

            return RedirectToAction("Basket");
        }
    }
}