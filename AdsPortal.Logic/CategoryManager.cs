using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsPortal.Logic
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
                Title = "Elektronika"
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Apģērbs"
            });

            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Tālruņi",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Televizori",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Vīriešu",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 6,
                Title = "Sieviešu",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 7,
                Title = "Bērnu",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 8,
                Title = "Velosipēdi"
            });
            Categories.Add(new Category()
            {
                Id = 9,
                Title = "Automašīnas"
            });
        }
    }
}
