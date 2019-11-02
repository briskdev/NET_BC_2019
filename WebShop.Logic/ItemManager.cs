using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class ItemManager
    {
        WebShopDb _db;

        public ItemManager(WebShopDb db)
        {
            _db = db;
        }

        public List<Item> GetByCategory(int categoryId)
        {
            var items = _db.Items
                .Where(i => i.CategoryId == categoryId)
                .ToList();

            return items;
        }

        public Item Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();

            return item;
        }

        public void Update(Item item)
        {
            var currentItem = _db.Items.FirstOrDefault(i => i.Id == item.Id);
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;
            currentItem.Description = item.Description;
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _db.Items.FirstOrDefault(i => i.Id == id);
            _db.Items.Remove(item);

            _db.SaveChanges();
        }

        public Item Get(int id)
        {
            var item = _db.Items.FirstOrDefault(i => i.Id == id);
            return item;
        }

        public void Seed()
        {
        }
    }
}
