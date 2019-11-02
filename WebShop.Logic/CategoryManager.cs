using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        WebShopDb _db;

        public CategoryManager(WebShopDb db)
        {
            _db = db;
        }

        public List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Category Get(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);

            return category;
        }

        public void Seed()
        {
            
        }
    }
}
