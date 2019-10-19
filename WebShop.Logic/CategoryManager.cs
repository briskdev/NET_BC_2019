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

        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics"
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Phones",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "TV",
                CategoryId = 1
            });
        }
    }
}
