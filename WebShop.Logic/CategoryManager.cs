using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        private List<Category> Categories;

        public CategoryManager()
        {
            Categories = new List<Category>();
        }

        public List<Category> GetAll()
        {
            return Categories;
        }

        public Category Get(int id)
        {
            var category = Categories.Find(c => c.Id == id);

            return category;
        }
    }
}
