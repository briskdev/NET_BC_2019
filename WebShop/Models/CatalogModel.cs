using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Logic;

namespace WebShop.Models
{
    public class CatalogModel
    {
        public List<Item> Items { get; set; }

        public List<Category> Categories { get; set; }
    }
}
