using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    class ItemManager
    {
        private int CurrentId;
        private List<Item> Items;

        public ItemManager()
        {
            CurrentId = 100;
            Items = new List<Item>();
        }

        public List<Item> GetByCategory(int categoryId)
        {
            var items = Items.FindAll(i => i.CategoryId == categoryId);

            return items;
        }

        public Item Create(Item item)
        {
            item.Id = CurrentId;
            Items.Add(item);
            CurrentId++;

            return item;
        }

        public void Update(Item item)
        {
            var currentItem = Items.Find(i => i.Id == item.Id);
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;
            currentItem.Description = item.Description;
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;
        }

        public void Delete(int id)
        {
            var item = Items.Find(i => i.Id == id);
            Items.Remove(item);
        }

        public Item Get(int id)
        {
            var item = Items.Find(i => i.Id == id);
            return item;
        }
    }
}
