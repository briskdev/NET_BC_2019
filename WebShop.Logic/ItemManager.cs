using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class ItemManager : BaseManager<Item>
    {
        public ItemManager(WebShopDb db)
            :base(db)
        {
           
        }

        protected override DbSet<Item> Table
        {
            get
            {
                return _db.Items;
            }
        }

        public List<Item> GetByCategory(int categoryId)
        {
            var items = _db.Items
                .Where(i => i.CategoryId == categoryId)
                .ToList();

            return items;
        }

        public void Seed()
        {
        }
    }
}
